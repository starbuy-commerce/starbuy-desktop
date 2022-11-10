using System;
using System.Net; 
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace Starbuy_Desktop
{
    
public partial class FormConfig : Form {

        private Usuario user;
        private MultiplosEnderecosResponse address;
        int controller = 0;
        private Image ImgEnviar;
        private String path;
        public FormConfig() {
            this.user = Session.getSession().getUser();
            this.address = MultiplosEnderecosResponse.getEnderecosResponse();
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e) {
            ///Deixando os label transparentes!
            labelConfigNome.Parent = pictureBoxBackground;
            labelConfigNome.BackColor = Color.Transparent;
            labelConfigID.Parent = pictureBoxBackground;
            labelConfigID.BackColor = Color.Transparent;
            labelConfigConfig.Parent = pictureBoxBackground;
            labelConfigConfig.BackColor = Color.Transparent;
            labelConfigCantoNome.Text = user.name;
            labelConfigNome.Text = user.name;
            labelConfigUsername.Text = user.username;
            labelConfigCidade.Text = user.city;
            ReSize.buttonResize(button1);
            ReSize.groupBoxResize(groupBox2);
            ReSize.groupBoxResize(groupBoxConfigAlterar);
            ReSize.groupBoxResize(gboxConfigMenu);
            ReSize.groupBoxResize(gboxConfigPerfil);
            ReSize.buttonResize(btnAdicionarFoto);

            ReSize.labelResize(labelConfigAlterar);
            ReSize.labelResize(labelConfigAlterarCEP);
            ReSize.labelResize(labelConfigAlterarCpf);
            ReSize.labelResize(labelConfigAlterarEndereco);
            ReSize.labelResize(labelConfigAlterarFoto);
            ReSize.labelResize(labelConfigAlterarNome);
            ReSize.labelResize(labelConfigAlterarTelefone);
            ReSize.labelResize(labelConfigCantoNome);
            ReSize.labelResize(lblCep);
            ReSize.labelResize(labelConfigCidade);
            ReSize.labelResize(labelConfigID);
            ReSize.labelResize(labelConfigConfig);
            ReSize.labelResize(lblEmail);
            ReSize.labelResize(lblNum);
            ReSize.labelResize(labelConfigInfCidade);
            ReSize.labelResize(lblComplemento);
            ReSize.labelResize(labelConfigInfUsername);
            ReSize.labelResize(labelConfigNome);
            ReSize.labelResize(labelConfigUsername);
            ReSize.labelResize(lblRespCep);
            ReSize.labelResize(lblRespComplemento);
            ReSize.labelResize(lblResultEmail);
            ReSize.labelResize(lblRespNum);
            ReSize.labelResize(label1);
            ReSize.comboBoxResise(comboBoxEndereco);

            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross, pictureBoxMenuVendedorCross.Image);
            ReSize.pictureCrossBox(pictureBoxConfigMenu, pictureBoxConfigMenu.Image);
            ReSize.pictureCrossBox(pictureBoxConfigEstoque, pictureBoxConfigEstoque.Image);
            ReSize.pictureCrossBox(pictureBoxConfigFoto, pictureBoxConfigFoto.Image) ;
            ReSize.pictureCrossBox(pictureBoxConfigPedidos, pictureBoxConfigPedidos.Image);
            ReSize.pictureCrossBox(pictureBoxBackground, pictureBoxBackground.Image);
            ReSize.pictureCrossBox(pictureBoxConfigCanto, pictureBoxConfigCanto.Image);
            ReSize.pictureCrossBox(pictureBoxConfigConfig, pictureBoxConfigConfig.Image);

            ReSize.textBoxResize(textBoxConfigAlterarCEP);
            ReSize.textBoxResize(textBoxConfigAlterarCpf);
            ReSize.textBoxResize(textBoxConfigAlterarEndereco);
            ReSize.textBoxResize(textBoxConfigAlterarNome);
            ReSize.textBoxResize(textBoxConfigAlterarTelefone);


            //Puxando imagem do servidor
            if (!string.IsNullOrEmpty(user.profile_picture))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(user.profile_picture);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 56, 50));
                pictureBoxConfigCanto.Image = resizeSmall;
                pictureBoxConfigCanto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                System.Drawing.Image resizeProfile = (new Bitmap(img, 179, 179));
                pictureBoxConfigFoto.Image = resizeProfile;
                pictureBoxConfigFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            }
            if (MultiplosEnderecosResponse.getEnderecosResponse() == null)
            {
                MessageBox.Show("A");
            }
            else
            {
                lblRespCep.Text = address.getAddress(0).cep;
                lblRespComplemento.Text = address.getAddress(0).complement;
                lblRespNum.Text = address.getAddress(0).number.ToString();
                comboBoxEndereco.Items.Clear(); 
                foreach(Address ad in address.getAddresses())
                {
                    comboBoxEndereco.Items.Add(ad.cep);
                }
            }
        }

        private void pictureBoxMenuVendedorCross_Click(object sender, EventArgs e) {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes) {
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void pictureBoxConfigMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void pictureBoxConfigPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void pictureBoxConfigEstoque_Click(object sender, EventArgs e) 
        {
            this.Close();
            FormEstoque estoque = new FormEstoque();
            estoque.Show();
        }

        private void comboBoxEndereco_SelectedIndexChanged(object sender, EventArgs e)
        {
            int buscar = comboBoxEndereco.SelectedIndex;
            lblRespCep.Text = address.getAddress(buscar).cep;
            lblRespComplemento.Text = address.getAddress(buscar
                ).complement;
            lblRespNum.Text = address.getAddress(buscar).number.ToString();
            textBoxConfigAlterarCEP.Text = address.getAddress(buscar).cep;
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Achar foto!";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImgEnviar = new Bitmap(dialog.OpenFile());
                    path = dialog.FileName;
                    MessageBox.Show(path);
                }
                catch (Exception er)
                {

                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }


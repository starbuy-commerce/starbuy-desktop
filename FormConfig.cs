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

            ReSize.labelResize(labelConfigAlterar);
            ReSize.labelResize(labelConfigAlterarCEP);
            ReSize.labelResize(labelConfigAlterarCpf);
            ReSize.labelResize(labelConfigAlterarEndereco);
            ReSize.labelResize(labelConfigAlterarFoto);
            ReSize.labelResize(labelConfigAlterarNome);
            ReSize.labelResize(labelConfigAlterarTelefone);
            ReSize.labelResize(labelConfigCantoNome);
            ReSize.labelResize(labelConfigCep);
            ReSize.labelResize(labelConfigCidade);
            ReSize.labelResize(labelConfigID);
            ReSize.labelResize(labelConfigConfig);
            ReSize.labelResize(labelConfigInfCep);
            ReSize.labelResize(labelConfigInfCidade);
            ReSize.labelResize(labelConfigInfTelefone);
            ReSize.labelResize(labelConfigInfUsername);
            ReSize.labelResize(labelConfigNome);
            ReSize.labelResize(labelConfigTelefone);
            ReSize.labelResize(labelConfigUsername);

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
            ReSize.textBoxResize(textBoxConfigAlterarFoto);
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
            // Adicionar verificação de endereço null//

                /*Adicionando Endereços
                labelConfigCep.Text = address.getAddress(0).cep.ToString();
                labelConfigEndereco.Text = user.city.ToString();
                labelConfigUsername.Text = user.username.ToString();
                */
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
    }
}

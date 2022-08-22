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
    
public partial class FormEstoque : Form {

        private Usuario user;
        private ItemsResponse itens;

        public FormEstoque() {
            this.user = Session.getSession().getUser();
            InitializeComponent();

            ReSize.labelResize(labelEstoqueCantoNome);
            ReSize.labelResize(labelEstoqueEstoque);

            ReSize.groupBoxResize(gboxEstoqueMenu);
            ReSize.groupBoxResize(gboxEstoquePerfil);
            ReSize.groupBoxResize(groupBoxPainelEstoque);

            ReSize.pictureCrossBox(pictureBoxEstoqueCanto);
            ReSize.pictureCrossBox(pictureBoxEstoqueConfiguracoes);
            ReSize.pictureCrossBox(pictureBoxEstoqueEstoque);
            ReSize.pictureCrossBox(pictureBoxEstoqueMenu);
            ReSize.pictureCrossBox(pictureBoxEstoquePedidos);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross);
        }

        private void FormEstoque_Load(object sender, EventArgs e) {
            labelEstoqueCantoNome.Text = user.name;
            if (!string.IsNullOrEmpty(user.profile_picture))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(user.profile_picture);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 57, 51));
                pictureBoxEstoqueCanto.Image = resizeSmall;
            }
            //alo! chamar aqui, viu?
        }

        private void pictureBoxEstoqueMenuVendedorCross_Click(object sender, EventArgs e) {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes) {
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void pictureBoxEstoqueMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void pictureBoxEstoquePedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void pictureBoxEstoqueConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Close();
            FormConfig config = new FormConfig();
            config.Show();
        }
	    private void configPainel()
        {

            int i;
            int a = itens.getAllProdutos().Length;
            int x;
            x = 4; //mudar, tem que ver o tamanho de cada grupBox a ser criado, acho que deve caber uns 4 mas ainda não sei 
     

            for (i = 0; i < a ; i++) {
                criarGroupBoxItem(i);
                if (i >= x)
                { // esse número é definido pela quantidade de itens q cabem em um painel
                    // break;
                }
            }
        }

        private void criarGroupBoxItem(int i)
        {

        }
    }
}



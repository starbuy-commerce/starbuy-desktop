using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuy_Desktop
{
    public partial class FormMenu : Form {

        private Usuario user;
        public FormMenu() {
            this.user = Session.getSession().getUser();
            InitializeComponent();
            ReSize.labelResize(labelConfigCantoNome);
            ReSize.labelResize(labelMenuAndam);
            ReSize.labelResize(labelMenuEstoque);
            ReSize.labelResize(labelMenuNovo);
            ReSize.labelResize(labelMenuQuantidade);
            ReSize.pictureCrossBox(pictureBoxConfigCanto, pictureBoxConfigCanto.Image);
            ReSize.pictureCrossBox(pictureBoxMenuConfig, pictureBoxMenuConfig.Image);
            ReSize.pictureCrossBox(pictureBoxMenuEstoque, pictureBoxMenuEstoque.Image);
            ReSize.pictureCrossBox(pictureBoxMenuMenu, pictureBoxMenuMenu.Image);
            ReSize.pictureCrossBox(pictureBoxMenuPedidos, pictureBoxMenuPedidos.Image);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross, pictureBoxMenuVendedorCross.Image);
            ReSize.groupBoxResize(gboxConfigPerfil);
            ReSize.groupBoxResize(gboxMenu);
            ReSize.groupBoxResize(gboxMenuAndam);
            ReSize.groupBoxResize(gboxMenuAndam1);
            ReSize.groupBoxResize(gboxMenuAndam2);
            ReSize.groupBoxResize(gboxMenuAndam3);
            ReSize.groupBoxResize(gboxMenuEstoque);
            ReSize.groupBoxResize(gboxMenuEstoque1);
            ReSize.groupBoxResize(gboxMenuEstoque2);
            ReSize.groupBoxResize(gboxMenuEstoque3);
            ReSize.groupBoxResize(gboxMenuNovo);
            ReSize.groupBoxResize(gboxMenuNovo1);
            ReSize.groupBoxResize(gboxMenuNovo2);
            ReSize.groupBoxResize(gboxMenuNovo3);
            ReSize.groupBoxResize(gboxMenuNovo4);
            ReSize.groupBoxResize(gboxMenuQuantidade);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelConfigCantoNome.Text = Session.getSession().getUser().name;
            if (!string.IsNullOrEmpty(user.profile_picture))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(user.profile_picture);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 57, 51));
                pictureBoxConfigCanto.Image = resizeSmall;
            }
        }

        private void pictureBoxMenuVendedorCross_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes)
            {
                this.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }

        private void pictureBoxMenuEstoque_Click(object sender, EventArgs e)
        {
            this.Close();

            FormEstoque estoque = new FormEstoque();
            estoque.Show();
        }

        private void pictureBoxMenuPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void pictureBoxMenuConfig_Click(object sender, EventArgs e)
        {
            this.Close();
            FormConfig config = new FormConfig();
            config.Show();
        }
    }
}

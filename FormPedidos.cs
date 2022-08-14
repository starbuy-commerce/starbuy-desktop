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
    public partial class FormPedidos : Form
    {
        private Usuario user;
        public FormPedidos()
        {
            this.user = Session.getSession().getUser();
            InitializeComponent();
        }

        private void pictureBoxMenuVendedorCross_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes)
            {
                this.Hide();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void pictureBoxPedidosConfig_Click(object sender, EventArgs e)
        {
            FormConfig config = new FormConfig();
            config.Show();
            this.Hide();
        }

        private void pictureBoxPedidosMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void pictureBoxPedidosEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            FormEstoque estoque = new FormEstoque();
            estoque.Show(); 
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuy_Desktop
{
    public partial class FormPedidos : Form
    {
        private LoginResponse lgresponse;
        public FormPedidos()
        {
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
            /*FormEstoque estoque = new FormEstoque();
            estoque.Show(); //criar forms de estoque */
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Session.getSession().getUser().name.ToString());
                Produto[] pr = API.getProducts(Session.getSession().getUser().name);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}

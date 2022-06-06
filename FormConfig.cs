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
    
public partial class FormConfig : Form
    {
        private LoginResponse lgResponse;
        public FormConfig(LoginResponse lg)
        {
            InitializeComponent();
            lgResponse = lg;
        }
        private void labelMenuMenuConfig_Click(object sender, EventArgs e)
        {

        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            labelConfigCantoNome.Text = lgResponse.user.name;
            labelConfigNome.Text = lgResponse.user.name;
            labelConfigEndereco.Text = lgResponse.user.city;
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

        private void pictureBoxConfigMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(lgResponse);
            menu.Show();
        }

        private void pictureBoxConfigPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void pictureBoxConfigEstoque_Click(object sender, EventArgs e)
        {
            /*FormEstoque estoque = new FormEstoque();
            estoque.Show(); //criar forms de estoque */
        }
    }
}

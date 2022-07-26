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
    public partial class FormRegistro : Form
    {
        MaskedTextBox dynamicMaskedTextBox;
        public FormRegistro()
        {
            InitializeComponent();
            dynamicMaskedTextBox = maskedTextBox1;
        }

        private void pictureBoxRegistroCross_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes)
            {
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRegistroNome.Text) || String.IsNullOrEmpty(textBoxRegistroCPF.Text) || String.IsNullOrEmpty(textBoxRegistroUsuario.Text))
            {
                MessageBox.Show("Preencha todos os valores!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

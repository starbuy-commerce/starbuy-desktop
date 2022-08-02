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
        ToolTip toolTipDate = new ToolTip();

        public FormRegistro()
        {
            InitializeComponent();
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
            if (String.IsNullOrEmpty(textBoxRegistroNome.Text) || String.IsNullOrEmpty(textBoxRegistroCPF.Text) || String.IsNullOrEmpty(textBoxRegistroUsuario.Text)
                || !maskedTextBoxRegistroNascimento.MaskCompleted || String.IsNullOrEmpty(textBoxRegistroEndereco.Text) || String.IsNullOrEmpty(textBoxRegistroTelefone.Text))
            {
                MessageBox.Show("Preencha todos os valores!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if(textBoxRegistroSenha.Text == textBoxRegistroConfirmar.Text)
                {

                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            maskedTextBoxRegistroNascimento.Mask = "00/00/0000";
            maskedTextBoxRegistroNascimento.ValidatingType = typeof(System.DateTime);
            maskedTextBoxRegistroNascimento.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox1_TypeValidationCompleted);
            maskedTextBoxRegistroNascimento.KeyDown += new KeyEventHandler(maskedTextBoxRegistroNascimento_KeyDown);
            toolTipDate.IsBalloon = true;
        }

        void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTipDate.ToolTipTitle = "Data inválida";
                toolTipDate.Show("Você deve digitar um valor dentre os padrões de data!", maskedTextBoxRegistroNascimento, 0, -60, 4000);
            }
            else
            {
                DateTime minimum =  new DateTime(01 / 01 / 1900);
                DateTime maximum = (DateTime.Now);
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate < minimum || userDate > maximum)
                {
                    toolTipDate.ToolTipTitle = "Data de nascimento inválida!";
                    toolTipDate.Show("A data deve estar entre 01/01/1900 e " + maximum.ToString(), maskedTextBoxRegistroNascimento,0, -20, 5000);
                    e.Cancel = true;
                }

            }
        }

        private void maskedTextBoxRegistroNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipDate.Hide(maskedTextBoxRegistroNascimento);
        }
    }
}
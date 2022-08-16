using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Text.Json;
using System.Net.Http;
using System.IO;

namespace Starbuy_Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLoginSenha.PasswordChar = '*';
            int formHeight = this.Height;
            int formWidth = this.Width;
            new ReSize(formHeight, formWidth);
            ReSize.pictureCrossBox(pictureBoxLogin);
            //ReSize.pictureCrossBox(pictureBoxLoginCross);
            /*pictureBoxLogin.Location = new Point(formWidth * 820 / 1386, formHeight * 273 / 786);
            pictureBoxLogin.Height = formHeight * 551 / 786;
            pictureBoxLogin.Width = formWidth* 524/1386; */
        }

        private void pictureBoxLoginCross_MouseClick(object sender, MouseEventArgs e)
        {
            //Fechar forms!
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(diag == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void registerFormsOpen(object sender, MouseEventArgs e)
        {
            DialogResult diag = MessageBox.Show("Deseja-se registrar?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                this.Hide();
                FormRegistro f2 = new FormRegistro(); //Abrindo forms novo// 
                f2.ShowDialog(); // Arranjar jeito de voltar pro forms original  // e // jeito de fechar forms novo!//
            }
        }

        private void buttonLoginEntrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLoginUsername.Text) || String.IsNullOrEmpty(textBoxLoginSenha.Text))
            {
                MessageBox.Show("Preencha todos os valores!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else { 
                string username = textBoxLoginUsername.Text;
                string password = textBoxLoginSenha.Text;
                
                try {
                    var user = API.login(username, password);
                    if (user.seller) {
                        this.Hide();
                        FormMenu fVendedor = new FormMenu();
                        String a = Session.getSession().getUser().username.ToString();
                        MessageBox.Show(a);
                        //API.getProducts(a);
                        //API.getAddress(Session.getSession().getJWT());
                        fVendedor.Show();
                    } else {
                        MessageBox.Show("O aplicativo é exclusivo para vendedores", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                } catch(AuthException ex) {
                    MessageBox.Show(ex.Message, "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void textBoxLoginUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                textBoxLoginSenha.Focus();
            }
        }

        private void textBoxLoginSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                buttonLoginEntrar_Click(sender,e);
            }
        }

        private void labelLoginFacaConta_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

        }
    }
}

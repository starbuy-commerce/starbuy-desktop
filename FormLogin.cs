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

        }
                            

        private void textBoxLoginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLoginCross_MouseDoubleClick(object sender, MouseEventArgs e)
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
            //Fechar forms!
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
                /* var data = "\"{username\"" + textBoxLoginUsername.Text.ToString() + "\n" + "\"password\"" + textBoxLoginSenha.Text.ToString() + "}\"";
                
                var wb = new WebClient();
                string url = "https://tcc-web-api.herokuapp.com/login";
                
                var response = wb.UploadValues(url, "POST", data); */
                var url = "https://reqbin.com/echo/post/json";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Headers["Authorization"] = "Bearer mt0dgHmLJMVQhvjpNXDyA83vA_PxH23Y";
                httpRequest.ContentType = "application/json";

                var data = @"{
                      ""Id"": 12345,
                      ""Customer"": ""John Smith"",
                      ""Quantity"": 1,
                      ""Price"": 10.00
                    }";

                using (var str = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    str.Write(data);
                }

                var response = (HttpWebResponse)httpRequest.GetResponse();
                if (response == null)
                {

                }
                else
                {
                    Usuario user = JsonSerializer.Deserialize<Usuario>(response);
                    labelLoginStarbuy.Text = user.city.ToString();
                }
            }
        }
    }
}

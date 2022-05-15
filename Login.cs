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
    public partial class Login : Form
    {
        public Login()
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
                Registro f2 = new Registro(); //Abrindo forms novo// 
                f2.ShowDialog(); // Arranjar jeito de voltar pro forms original  // e // jeito de fechar forms novo!//
            }
        }

    }
}

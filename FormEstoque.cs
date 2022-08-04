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

        public FormEstoque() {
            this.user = Session.getSession().getUser();
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e) {
            labelEstoqueCantoNome.Text = user.name;
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
	private void groupBoxPainelEstoque_Enter(object sender, EventArgs e)
        {
            // por algum motivo estruturas como for e if não estão funcionando, vou dar um commit pra salvar as alterãções e continuo investigando isso ai 

            int i;
            int a;
            int x;
            x = 4; //mudar, tem que ver o tamanho de cada grupBox a ser criado, acho que deve caber uns 4 mas ainda não sei 
            a = items.length(); // tem que criar o "items", algo que consiga contar o número de itens que o cliente tem registrado 

            For(i = 0; i < a ; i++;){
                criarGroupBoxItem(i);
                If(i >= x)
                { // esse número é definido pela quantidade de itens q cabem em um painel
                 break;
                }
            }
        }
    }
}

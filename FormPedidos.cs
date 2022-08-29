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

            ReSize.buttonResize(btnPedidosAtualizar);

            ReSize.groupBoxResize(gboxConfigMenu);
            ReSize.groupBoxResize(gboxConfigPerfil);
            ReSize.groupBoxResize(gboxPedidosBaixa);
            ReSize.groupBoxResize(gboxPedidosPedidos);

            /*Caixas dos pedidos
            ReSize.groupBoxResize(gboxPedidos1);
            ReSize.groupBoxResize(gboxPedidos2);
            ReSize.groupBoxResize(gboxPedidos3);
            ReSize.groupBoxResize(gboxPedidos4);
            ReSize.groupBoxResize(gboxPedidos5);*/ //Tirei pra ver se dá pra gerar automaticamente

            // FAZER O RESIZE DO PANEL!!!! - se der certo fazer o treco lá com ele

            ReSize.labelResize(labelConfigCantoNome);
            ReSize.labelResize(labelPedidos);
            ReSize.labelResize(labelPedidosBaixa);
            ReSize.labelResize(labelPedidosNumero);

            ReSize.pictureCrossBox(pictureBoxConfigCanto);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross);
            ReSize.pictureCrossBox(pictureBoxPedidosConfig);
            ReSize.pictureCrossBox(pictureBoxPedidosEstoque);
            ReSize.pictureCrossBox(pictureBoxPedidosMenu);
            ReSize.pictureCrossBox(pictureBoxPedidosPedidos);

            ReSize.textBoxResize(textBoxBaixa);


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
            labelConfigCantoNome.Text = user.name;
            if (!string.IsNullOrEmpty(user.profile_picture))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(user.profile_picture);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 57, 51));
                pictureBoxConfigCanto.Image = resizeSmall;


                /* gerar os pedidos
                
                foreach( referenciar o "Produtos GetProdutos" do ItemResponse) // assim vai passar pelo loop para cada produto que o usuário tiver
                {
                    GerarPedidos();
                }

                // algo assim:
                foreach (DataRow itm in data.Rows)
                {
                    if (itm["CategoryName"].ToString() != CurrentGroupBoxName)
                    {
                        flpRedMarks.Controls.Add(GetGroupBox(itm, 200, 100));
                    }
                }
               // */

            }
        }

        private GroupBox GetGroupBox(DataRow c, int width, int height)
        {
            /*//referênciar cada caracteristica do produto a uma variavel
            // não sei pq ta dando que ela é estática, tipo??? não depende do que ela pegar no banco??
            // do jeito que tá aqui embaixo não tava dando certo mas vou deixar aqui por enquanto pq nunca se sabe né
                string id = Item.identifier;
                string titleprod = Item.title;
                double priceprod = Item.price;
                int stockprod = Item.stock;
                int categoryprod = Item.category;
                string descriptionprod = Item.description;
            */
            // criar o componente - um groupbox - com as inf do produto dentro 

            GroupBox currentGroupBox = new GroupBox();
            currentGroupBox.Size = new Size(width, height); // tamanho do groupbox

            currentGroupBox.Text = Item.title.ToString();
            currentGroupBox.Name = Item.title.ToString();
            // CurrentGroupBoxName = currentGroupBox.Name;

            //testar se realmente ta gerando alguma coisa certa
            var y = 20;
            foreach (var itm in c.Table.Rows)
            {
                // atribuindo o título do produto
                Label titulo = new Label();
                titulo.Text = Item.title.ToString();
                titulo.Location = new Point(5, y); //localização do titulo
                currentGroupBox.Controls.Add(titulo); // 

                // atribuindo o id do produto
                Label id = new Label();
                id.Text = Item.identifier.ToString();
                id.Location = new Point(6, y+1); //localização do id
                currentGroupBox.Controls.Add(id); //

                // atribuindo o preço do produto
                Label preco = new Label();
                preco.Text = Item.price.ToString();
                preco.Location = new Point(7, y+2); //localização do preço
                currentGroupBox.Controls.Add(preco); //


                // atribuindo a quantidade em estoque do produto
                Label estoque = new Label();
                estoque.Text = Item.stock.ToString();
                estoque.Location = new Point(8, y+3); //localização do estoque
                currentGroupBox.Controls.Add(estoque); //

                // atribuindo a categoria do produto
                Label categoria = new Label();
                categoria.Text = Item.category.ToString();
                categoria.Location = new Point(9, y + 4); //localização da categoria
                currentGroupBox.Controls.Add(categoria); //

                // atribuindo a descrição do produto
                Label descricao = new Label();
                descricao.Text = Item.description.ToString();
                descricao.Location = new Point(10, y + 5); //localização da categoria
                currentGroupBox.Controls.Add(descricao); //

                y += 20;
            }

            return currentGroupBox;

        }
    }
}

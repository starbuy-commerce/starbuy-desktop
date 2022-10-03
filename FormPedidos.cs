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
        private ItemsResponse items;
        public FormPedidos()
        {
            this.user = Session.getSession().getUser();
            this.items = ItemsResponse.GetItemsResponse(); // alterar para recieved Orders + criar classe
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

            ReSize.pictureCrossBox(pictureBoxConfigCanto, pictureBoxConfigCanto.Image);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross, pictureBoxMenuVendedorCross.Image);
            ReSize.pictureCrossBox(pictureBoxPedidosConfig, pictureBoxPedidosConfig.Image);
            ReSize.pictureCrossBox(pictureBoxPedidosEstoque, pictureBoxPedidosEstoque.Image);
            ReSize.pictureCrossBox(pictureBoxPedidosMenu, pictureBoxPedidosMenu.Image);
            ReSize.pictureCrossBox(pictureBoxPedidosPedidos, pictureBoxPedidosPedidos.Image);

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
            }

            //gerar os pedidos
            if (items == null)
            {
                //Mostrar tela zero pedidos
                MessageBox.Show("a");
            }
            else
            {
                MessageBox.Show("b");
                int i = 0;
                foreach (Produtos product in this.items.getAllProdutos()) // assim vai passar pelo loop para cada produto que o usuário tiver
                { 
                    //GetGroupBox(product,i);
                    i++;
                }

                // algo assim:
                /* foreach (DataRow itm in data.Rows)
                {
                    if (itm["CategoryName"].ToString() != CurrentGroupBoxName)
                    {
                        flpRedMarks.Controls.Add(GetGroupBox(itm, 200, 100));
                    }
                } */
            }
        }

        /*private void GetGroupBox(Produtos p,int i)
        {
            //referênciar cada caracteristica do produto a uma variavel
            string id = p.item.identifier.ToString();
            string titleprod = p.item.title;
            string  priceprod = p.item.price.ToString();
            string stockprod = p.item.stock.ToString();
            string categoryprod = p.item.category.ToString();
            string descriptionprod = p.item.description;

            GroupBox currentGroupBox = new GroupBox(); 
            currentGroupBox.Size = new Size(684, 135); // definir tamanho do groupbox
            currentGroupBox.Location = new Point(3, 4 + i * 50 + i * 135);

            // arrumar as localizações dos itens
            // atribuindo o título do produto
            Label titulo = new Label();
            titulo.Text = titleprod;
            titulo.Location = new Point(127, 24); //localização do titulo
            currentGroupBox.Controls.Add(titulo); 

            // atribuindo o id do produto
            Label ident = new Label();
            ident.Text = id;
            ident.Location = new Point(6, 1); //localização do id
            currentGroupBox.Controls.Add(ident); 

            // atribuindo o preço do produto
            Label preco = new Label();
            preco.Text = priceprod;
            preco.Location = new Point(127, 55); //localização do preço
            currentGroupBox.Controls.Add(preco);


            // atribuindo a quantidade em estoque do produto
            Label estoque = new Label();
            estoque.Text = stockprod;
            estoque.Location = new Point(8, 1); //localização do estoque
            currentGroupBox.Controls.Add(estoque);

            // atribuindo a categoria do produto
            Label categoria = new Label();
            categoria.Text = categoryprod;
            categoria.Location = new Point(9, 1); //localização da categoria
            currentGroupBox.Controls.Add(categoria); 

            // atribuindo a descrição do produto
            Label descricao = new Label();
            descricao.Text = descriptionprod;
            descricao.Location = new Point(10, 1); //localização da categoria
            currentGroupBox.Controls.Add(descricao);
            currentGroupBox.Visible = true;
            panelPedidos.Controls.Add(currentGroupBox);

        }*/
    }
}

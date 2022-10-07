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
        private OrdersResponse orders;
        private int currentGroupProducts = 0;
        private int ultPag = 0;

        public FormPedidos()
        {
            this.user = Session.getSession().getUser();
            this.items = ItemsResponse.GetItemsResponse(); // alterar para recieved Orders + criar classe
            InitializeComponent();

            ReSize.buttonResize(btnPedidosAtualizar);

            ReSize.groupBoxResize(gboxConfigMenu);
            ReSize.groupBoxResize(gboxConfigPerfil);
            ReSize.groupBoxResize(gboxPedidosBaixa);

            /*Caixas dos pedidos
            ReSize.groupBoxResize(gboxPedidos1);
            ReSize.groupBoxResize(gboxPedidos2);
            ReSize.groupBoxResize(gboxPedidos3);
            ReSize.groupBoxResize(gboxPedidos4);
            ReSize.groupBoxResize(gboxPedidos5);*/ //Tirei pra ver se dá pra gerar automaticamente

            // FAZER O RESIZE DO PANEL!!!! - se der certo fazer o treco lá com ele

            ReSize.labelResize(labelConfigCantoNome);
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
            if (orders == null)
            {
                //Mostrar tela zero pedidos
                MessageBox.Show("a");
            }
            else
            {
                MessageBox.Show("b");
                int i = 0;
                foreach (Produtos product in this.orders.getAllProdutosFromOrder(0)) // assim vai passar pelo loop para cada produto que o usuário tiver
                { 
                    GetGroupBox(product,i);
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
        private void GetGroupBox(Produtos p, int i)
        {
            //referênciar cada caracteristica do produto a uma variavel
            string id = p.item.identifier.ToString();
            string titleprod = p.item.title;
            string priceprod = p.item.price.ToString();
            string stockprod = p.item.stock.ToString();
            string categoryprod = p.item.category.ToString();
            int cat = Int32.Parse(categoryprod);

            switch (cat)
            {
                case 1:
                    categoryprod = "Eletrônico";
                    break;
                case 2:
                    categoryprod = "Vestuário";
                    break;
                case 3:
                    categoryprod = "Casa";
                    break;
                case 4:
                    categoryprod = "Livros";
                    break;
                case 7:
                    categoryprod = "Música";
                    break;
            }

            string descriptionprod = p.item.description;

            GroupBox currentGroupBox = new GroupBox();
            currentGroupBox.Size = new Size(756, 135); // definir tamanho do groupbox
            currentGroupBox.Location = new Point(3, 4 + i * 50 + i * 135);
            //adicionando imagens
            //REVER LÓGICA DE IMAGENS NULAS
            if (p.assets[0] == null)
            {
                //não tem imagem
            }
            else
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(p.assets[0]);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 106, 106));
                PictureBox imagemProduto = new PictureBox();
                imagemProduto.Location = new Point(17, 22);
                imagemProduto.Image = resizeSmall;
                imagemProduto.Width = 98;
                imagemProduto.Height = 98;
                currentGroupBox.Controls.Add(imagemProduto);
                ReSize.pictureCrossBox(imagemProduto, imagemProduto.Image);
            }

            // arrumar as localizações dos itens
            // atribuindo o título do produto
            Label titulo = new Label();
            titulo.Text = titleprod;
            titulo.Location = new Point(127, 24); //localização do titulo
            currentGroupBox.Controls.Add(titulo);

            // atribuindo o preço do produto
            Label preco = new Label();
            preco.Text = "Preço: " + priceprod;
            preco.Location = new Point(127, 55); //localização do preço
            currentGroupBox.Controls.Add(preco);


            // atribuindo a quantidade em estoque do produto
            Label estoque = new Label();
            estoque.Text = "Quantidade em estoque: " + stockprod;
            estoque.Location = new Point(276, 55); //localização do estoque
            currentGroupBox.Controls.Add(estoque);

            // atribuindo a categoria do produto
            Label categoria = new Label();
            categoria.Text = "Categoria: " + categoryprod;
            categoria.Location = new Point(487, 55); //localização da categoria
            currentGroupBox.Controls.Add(categoria);

            // atribuindo a descrição do produto
            Label descricao = new Label();
            descricao.Text = descriptionprod;
            descricao.Location = new Point(127, 91); //localização da categoria
            currentGroupBox.Controls.Add(descricao);
            currentGroupBox.Visible = true;
            ReSize.labelResize(titulo);
            ReSize.labelResize(preco);
            ReSize.labelResize(descricao);
            ReSize.labelResize(estoque);
            ReSize.labelResize(categoria);
            ReSize.groupBoxResize(currentGroupBox);
            panel1.Controls.Add(currentGroupBox);
        }


        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (((currentGroupProducts + 1) * 3) >= items.getAllProdutos().Length)
            {
                MessageBox.Show("Você já está na última página!", null);
            }
            else
            {
                currentGroupProducts++;
                labelPagina.Text = "Página: " + (currentGroupProducts + 1) + " de " + ultPag;
                panel1.Controls.Clear();
                int i = 0;
                foreach (Produtos product in this.orders.getAllProdutosFromOrder(0))
                {
                    if ((currentGroupProducts * 3 - 1) > i)
                    {
                        i++;
                    }
                    else
                    {
                        GetGroupBox(product, (i - (currentGroupProducts * 3)));

                        if (i - (currentGroupProducts * 3 - 1) > 2)
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentGroupProducts == 0)
            {
                MessageBox.Show("Você já está na primeira página!", null);
            }
            else
            {
                currentGroupProducts--;
                labelPagina.Text = "Página: " + (currentGroupProducts + 1) + " de " + ultPag;
                panel1.Controls.Clear();
                int i = 0;
                foreach (Produtos product in this.orders.getAllProdutosFromOrder(0))
                {
                    if ((currentGroupProducts * 3 - 1) > i)
                    {
                        i++;
                    }
                    else
                    {
                        GetGroupBox(product, (i - (currentGroupProducts * 3)));

                        if (i - (currentGroupProducts * 3 - 1) > 2)
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
        }
    }
}

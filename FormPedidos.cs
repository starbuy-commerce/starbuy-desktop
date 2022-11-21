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
        private Categorias categorias = new Categorias();

        public FormPedidos()
        {
            this.user = Session.getSession().getUser();
            this.items = ItemsResponse.GetItemsResponse(); // alterar para recieved Orders + criar classe
            orders = OrdersResponse.GetOrdersResponse();
            InitializeComponent();

            ReSize.buttonResize(btnPedidosAtualizar);

            ReSize.groupBoxResize(gboxConfigMenu);
            ReSize.groupBoxResize(gboxConfigPerfil);
            ReSize.groupBoxResize(gboxPedidosBaixa);
            ReSize.panelResize(panel1);
            ReSize.buttonResize(btnAnterior);
            ReSize.buttonResize(btnProxima);
            ReSize.labelResize(labelPagina);
            ReSize.labelResize(labelEstoqueEstoque);


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
            ReSize.pictureCrossBox(pictureBoxConfigCanto);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross);
            ReSize.pictureCrossBox(pictureBoxPedidosConfig);
            ReSize.pictureCrossBox(pictureBoxPedidosEstoque);
            ReSize.pictureCrossBox(pictureBoxPedidosMenu);
            ReSize.pictureCrossBox(pictureBoxPedidosPedidos);
            ReSize.comboBoxResise(comboBox1);
            foreach(Order order in orders.getOrders())
            {
                comboBox1.Items.Add(order.identifier);
            }

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
                MessageBox.Show("a");
            }
            else
            {
                MessageBox.Show("b");
                int i = 0;
                if ((orders.getOrders().Length) % 3 == 0)
                {
                    ultPag = (orders.getOrders().Length) / 3;
                }
                else
                {
                    ultPag = (orders.getOrders().Length / 3) + 1;
                }
                labelPagina.Text = labelPagina.Text + "1 de " + ultPag.ToString();
                foreach (Order orders in orders.getOrders()) // assim vai passar pelo loop para cada produto que o usuário tiver
                {
                    GetGroupBox(orders, i);
                    i++;
                    if (i > 2) { break; }
                }
            }
        }
        private void GetGroupBox(Order o, int i)
        {
            //referênciar cada caracteristica do produto a uma variavel
            string titleprod = o.item_with_assets.item.title.ToString();
            string priceprod = o.price.ToString();
            string stockprod = o.quantity.ToString();
            int cat = o.item_with_assets.item.category;
            string categoryprod = categorias.getCategoria(cat);
            string descriptionprod = o.item_with_assets.item.description;
            int status = o.status;
            string identifierProd = o.identifier;
            String statusProd = "";
            switch (status)
            {
                case 0:
                    statusProd = "Preparando";
                    break;
                case 1:
                    statusProd = "Enviado";
                    break;
                case 2:
                    statusProd = "Entregue";
                    break;

            }

            GroupBox currentGroupBox = new GroupBox();
            currentGroupBox.Size = new Size(756, 160); 
            currentGroupBox.Location = new Point(3, 4 + i * 50 + i * 160);
            if (o.item_with_assets.assets[0] == null)
            {
                //não tem imagem
            }
            else
            {
                try
                {
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(o.item_with_assets.assets[0]);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image resizeSmall = (new Bitmap(img, 106, 106));
                    PictureBox imagemProduto = new PictureBox();
                    imagemProduto.Location = new Point(17, 22);
                    imagemProduto.Image = resizeSmall;
                    imagemProduto.Width = 98;
                    imagemProduto.Height = 98;
                    currentGroupBox.Controls.Add(imagemProduto);
                    ReSize.pictureCrossBox(imagemProduto);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            Label identifier = new Label();
            identifier.Text = "Identifier: " + identifierProd;
            identifier.Location = new Point(127, 34);
            identifier.Size = new Size(580, 15);
            currentGroupBox.Controls.Add(identifier);

            Label titulo = new Label();
            titulo.Text = titleprod;
            titulo.Location = new Point(127, 16);
            titulo.Size = new Size(580, 15);
            currentGroupBox.Controls.Add(titulo);


            Label preco = new Label();
            preco.Text = "Preço: " + priceprod;
            preco.Location = new Point(127, 55); 
            currentGroupBox.Controls.Add(preco);

            Label estoque = new Label();
            estoque.Text = "Quantidade pedida: " + stockprod;
            estoque.Size = new Size(190, 15);
            estoque.Location = new Point(276, 55); 
            currentGroupBox.Controls.Add(estoque);

            Label categoria = new Label();
            categoria.Text = "Categoria: " + categoryprod;
            categoria.Size = new Size(190, 15);
            categoria.Location = new Point(487, 55);
            currentGroupBox.Controls.Add(categoria);

            Label descricao = new Label();
            descricao.Text = descriptionprod;
            descricao.Location = new Point(127, 80); 
            descricao.Size = new Size(580, 45);
            currentGroupBox.Controls.Add(descricao);

            Label statusEntrega = new Label();
            statusEntrega.Text = "Status da entrega: " + statusProd;
            statusEntrega.Location = new Point(127, 130);
            statusEntrega.Size = new Size(260, 15);
            currentGroupBox.Controls.Add(statusEntrega);

            Button btnStatus = new Button();
            btnStatus.Text = "Alterar Status";
            btnStatus.Location = new Point(487, 130);
            currentGroupBox.Controls.Add(statusEntrega);

            currentGroupBox.Visible = true;
            ReSize.labelResize(identifier);
            ReSize.labelResize(statusEntrega);
            ReSize.labelResize(titulo);
            ReSize.labelResize(preco);
            ReSize.labelResize(descricao);
            ReSize.labelResize(estoque);
            ReSize.labelResize(categoria);
            ReSize.groupBoxResize(currentGroupBox);
            titulo.Font = new Font(titulo.Font, FontStyle.Bold);
            panel1.Controls.Add(currentGroupBox);
        }


        private void btnProxima_Click(object sender, EventArgs e)
        {
            {
                if (((currentGroupProducts + 1) * 3) >= orders.getOrders().Length)
                {
                    MessageBox.Show("Você já está na última página!", null);
                }
                else
                {
                    currentGroupProducts++;
                    labelPagina.Text = "Página: " + (currentGroupProducts + 1) + " de " + ultPag;
                    panel1.Controls.Clear();
                    int i = 0;
                    foreach (Order order in this.orders.getOrders())
                    {
                        if ((currentGroupProducts * 3 - 1) > i)
                        {
                            i++;
                        }
                        else
                        {
                            GetGroupBox(order, (i - (currentGroupProducts * 3)));

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
                foreach (Order order in this.orders.getOrders())
                {
                    if ((currentGroupProducts * 3 - 1) > i)
                    {
                        i++;
                    }
                    else
                    {
                        GetGroupBox(order, (i - (currentGroupProducts * 3)));

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

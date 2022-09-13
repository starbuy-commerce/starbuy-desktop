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
        private ItemsResponse items;

        public FormEstoque() {
            this.user = Session.getSession().getUser();
            this.items = ItemsResponse.GetItemsResponse();
            InitializeComponent();

            ReSize.labelResize(labelEstoqueCantoNome);
            ReSize.labelResize(labelEstoqueEstoque);

            ReSize.groupBoxResize(gboxEstoqueMenu);
            ReSize.groupBoxResize(gboxEstoquePerfil);

            ReSize.pictureCrossBox(pictureBoxEstoqueCanto);
            ReSize.pictureCrossBox(pictureBoxEstoqueConfiguracoes);
            ReSize.pictureCrossBox(pictureBoxEstoqueEstoque);
            ReSize.pictureCrossBox(pictureBoxEstoqueMenu);
            ReSize.pictureCrossBox(pictureBoxEstoquePedidos);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross);
        }

        private void FormEstoque_Load(object sender, EventArgs e) {
            labelEstoqueCantoNome.Text = user.name;
            if (!string.IsNullOrEmpty(user.profile_picture))
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(user.profile_picture);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 57, 51));
                pictureBoxEstoqueCanto.Image = resizeSmall;
            }
            //gerar os pedidos
            if (items.getAllProdutos() == null)
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
                    GetGroupBox(product, i);
                    i++;
                    if (i > 2) { break; }
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

        private void GetGroupBox(Produtos p, int i)
        {
            //referênciar cada caracteristica do produto a uma variavel
            string id = p.item.identifier.ToString();
            string titleprod = p.item.title;
            string priceprod = p.item.price.ToString();
            string stockprod = p.item.stock.ToString();
            string categoryprod = p.item.category.ToString();
            string descriptionprod = p.item.description;

            GroupBox currentGroupBox = new GroupBox();
            currentGroupBox.Size = new Size(756, 135); // definir tamanho do groupbox
            currentGroupBox.Location = new Point(3, 4 + i * 50 + i * 135);
            //adicionando imagens
            if (p.GetAsset(0) == null)
            {
                //não tem imagem
            }
            else
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(p.asset[0]);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image resizeSmall = (new Bitmap(img, 104, 106));
                PictureBox imagemProduto = new PictureBox();
                imagemProduto.Location = new Point(17, 22);
                imagemProduto.Image = resizeSmall;
                currentGroupBox.Controls.Add(imagemProduto);
            }

            // arrumar as localizações dos itens
            // atribuindo o título do produto
            Label titulo = new Label();
            titulo.Text = titleprod;
            titulo.Location = new Point(127, 24); //localização do titulo
            currentGroupBox.Controls.Add(titulo);

            // atribuindo o id do produto
            /*Label ident = new Label();
            ident.Text = id;
            ident.Location = new Point(6, 1); //localização do id
            currentGroupBox.Controls.Add(ident); */

            // atribuindo o preço do produto
            Label preco = new Label();
            preco.Text = priceprod;
            preco.Location = new Point(127, 55); //localização do preço
            currentGroupBox.Controls.Add(preco);


            // atribuindo a quantidade em estoque do produto
            Label estoque = new Label();
            estoque.Text = stockprod;
            estoque.Location = new Point(276, 55); //localização do estoque
            currentGroupBox.Controls.Add(estoque);

            // atribuindo a categoria do produto
            Label categoria = new Label();
            categoria.Text = "Categoria " + categoryprod;
            categoria.Location = new Point(487, 55); //localização da categoria
            currentGroupBox.Controls.Add(categoria);

            // atribuindo a descrição do produto
            Label descricao = new Label();
            descricao.Text = descriptionprod;
            descricao.Location = new Point(127, 91); //localização da categoria
            currentGroupBox.Controls.Add(descricao);
            currentGroupBox.Visible = true;
            panel1.Controls.Add(currentGroupBox);

        }
    }
}



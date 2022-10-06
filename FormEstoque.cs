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
        private Session session;
        private int currentGroupProducts = 0;
        private int ultPag = 0;

        public FormEstoque() {
            this.user = Session.getSession().getUser();
            this.items = ItemsResponse.GetItemsResponse();
            this.session = Session.getSession();
            InitializeComponent();

            ReSize.buttonResize(btnAnterior);
            ReSize.buttonResize(btnProxima);
            ReSize.buttonResize(btnAdicionar);

            ReSize.labelResize(labelPagina);
            ReSize.labelResize(labelEstoqueCantoNome);
            ReSize.labelResize(labelEstoqueEstoque);
            ReSize.labelResize(labelEstoqueAdicionar);
            ReSize.labelResize(labelAdicionarDescricao);
            ReSize.labelResize(labelAdicionarQuant);
            ReSize.labelResize(labelAdicionarValor);
            ReSize.labelResize(labelAdicionarFoto);
            ReSize.labelResize(labelAdicionarNome);
            ReSize.labelResize(labelAdicionarCategoria);

            ReSize.groupBoxResize(gboxEstoqueMenu);
            ReSize.groupBoxResize(gboxEstoquePerfil);
            ReSize.groupBoxResize(groupBoxConfigAlterar);
            ReSize.panelResize(panel1);

            ReSize.pictureCrossBox(pictureBoxEstoqueCanto, pictureBoxEstoqueCanto.Image);
            ReSize.pictureCrossBox(pictureBoxEstoqueConfiguracoes, pictureBoxEstoqueConfiguracoes.Image);
            ReSize.pictureCrossBox(pictureBoxEstoqueEstoque, pictureBoxEstoqueEstoque.Image);
            ReSize.pictureCrossBox(pictureBoxEstoqueMenu, pictureBoxEstoqueMenu.Image);
            ReSize.pictureCrossBox(pictureBoxEstoquePedidos, pictureBoxEstoquePedidos.Image);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross, pictureBoxMenuVendedorCross.Image);
            ReSize.textBoxResize(txtAdicionarDescricao);
            ReSize.textBoxResize(txtAdicionarQuant);
            ReSize.textBoxResize(txtAdicionarValor);
            ReSize.textBoxResize(txtAdicionarFoto);
            ReSize.textBoxResize(txtAdicionarNome);
            ReSize.textBoxResize(txtAdicionarCategoria);

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
            if (items == null)
            {
                //Mostrar tela zero pedidos
                MessageBox.Show("a");
            }
            else
            {
                MessageBox.Show((items.getAllProdutos().Length % 3).ToString());
                int i = 0;
                
                if((items.getAllProdutos().Length)%3 == 0)
                {
                    ultPag = (items.getAllProdutos().Length) / 3;
                }
                else
                {
                    ultPag = (items.getAllProdutos().Length / 3) + 1;
                }
                labelPagina.Text = labelPagina.Text + "1 de " + ultPag.ToString(); //ver maneira de verificar q pág tá
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
                System.Drawing.Image resizeSmall = (new Bitmap(img, 106 , 106));
                PictureBox imagemProduto = new PictureBox();
                imagemProduto.Location = new Point(17, 22);
                imagemProduto.Image = resizeSmall;
                currentGroupBox.Controls.Add(imagemProduto);
                ReSize.pictureCrossBox(imagemProduto, imagemProduto.Image);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAdicionarNome.Text) || String.IsNullOrWhiteSpace(txtAdicionarValor.Text) || String.IsNullOrWhiteSpace(txtAdicionarQuant.Text) || String.IsNullOrWhiteSpace(txtAdicionarCategoria.Text) || String.IsNullOrWhiteSpace(txtAdicionarDescricao.Text))
            {
                MessageBox.Show("Preencha todos os valores, não deixe nenhum campo vazio ou com apenas espaços!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                try
                {
                    int value = int.Parse(txtAdicionarValor.Text);
                    double quant = double.Parse(txtAdicionarQuant.Text);
                    CadastroNovoProduto prod = new CadastroNovoProduto(txtAdicionarNome.Text, this.user, int.Parse(txtAdicionarValor.Text), int.Parse(txtAdicionarQuant.Text), int.Parse(txtAdicionarCategoria.Text), txtAdicionarDescricao.Text);
                    Image assets = null; /*Atribuir a imagem pega do file
                    API.cadastrarNovoProduto(this.session.getJWT(), prod, assets);*/
                }
                catch(FormatException) {
                    MessageBox.Show("Os campos Quantidade e valor exigem valores numéricos, sendo o valor sendo escrito 9999.99", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (((currentGroupProducts+1)* 3) >= items.getAllProdutos().Length) {
                MessageBox.Show("Você já está na última página!", null);
            }
            else
            {
                currentGroupProducts++;
                labelPagina.Text = "Página: " + (currentGroupProducts+1) + " de " + ultPag;
                panel1.Controls.Clear();
                int i = 0;
                foreach (Produtos product in this.items.getAllProdutos())
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
                foreach (Produtos product in this.items.getAllProdutos())
                {
                    if ((currentGroupProducts * 3 - 1) > i)
                    {
                        i++;
                    }
                    else
                    {
                        GetGroupBox(product, (i - (currentGroupProducts * 3 )));
                        
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



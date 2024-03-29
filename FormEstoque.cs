﻿using System;
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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;

namespace Starbuy_Desktop
{
    
public partial class FormEstoque : Form {

        private Usuario user;
        private ItemsResponse items;
        private Session session;
        private int currentGroupProducts = 0;
        private int ultPag = 0;
        private string path;
        private Image ImagemEnviar;
        static int height, width;
        static double propWidth, propHeight;
        private Categorias categorias = new Categorias();

        public FormEstoque()
        {
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

            ReSize.comboBoxResise(comboBoxAdicionarAtualizar);
            ReSize.comboBoxResise(comboBoxAtualizarItem);
            ReSize.comboBoxResise(comboBoxCategorias);

            ReSize.pictureCrossBox(pictureBoxEstoqueCanto);
            ReSize.pictureCrossBox(pictureBoxEstoqueConfiguracoes);
            ReSize.pictureCrossBox(pictureBoxEstoqueEstoque);
            ReSize.pictureCrossBox(pictureBoxEstoqueMenu);
            ReSize.pictureCrossBox(pictureBoxEstoquePedidos);
            ReSize.pictureCrossBox(pictureBoxMenuVendedorCross);
            ReSize.textBoxResize(txtAdicionarDescricao);
            ReSize.textBoxResize(txtAdicionarQuant);
            ReSize.textBoxResize(txtAdicionarValor);
            ReSize.buttonResize(btnAdicionarFoto);
            ReSize.textBoxResize(txtAdicionarNome);

        }
        private void FormEstoque_Load(object sender, EventArgs e) {
            comboBoxAdicionarAtualizar.SelectedIndex = 0;
            for(int i = 0; categorias.getTodasCategorias().Length > i; i++)
            {
                comboBoxCategorias.Items.Add(categorias.getCategoria(i));
            }

            height = this.Height;
            width = this.Width;
            propWidth = (double)width / 1386;
            propHeight = (double)height / 786;

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
            else if (items.getAllProdutos() != null)
            {
                MessageBox.Show((items.getAllProdutos().Length % 3).ToString());
                int i = 0;
                comboBoxAtualizarItem.Items.Clear();
                foreach (Produtos product in this.items.getAllProdutos()) // assim vai passar pelo loop para cada produto que o usuário tiver
                {
                    comboBoxAtualizarItem.Items.Add(product.item.title);
                }

                if ((items.getAllProdutos().Length)%3 == 0)
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
                    //itens.Items.Add(i);
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

            pictureBoxEstoqueCanto.Image = ResizeImage(pictureBoxEstoqueCanto.Image);
            pictureBoxEstoqueConfiguracoes.Image = ResizeImage(pictureBoxEstoqueConfiguracoes.Image);
            pictureBoxEstoqueEstoque.Image = ResizeImage(pictureBoxEstoqueEstoque.Image);
            pictureBoxEstoqueMenu.Image = ResizeImage(pictureBoxEstoqueMenu.Image);
            pictureBoxEstoquePedidos.Image = ResizeImage(pictureBoxEstoquePedidos.Image);
            pictureBoxMenuVendedorCross.Image = ResizeImage(pictureBoxMenuVendedorCross.Image);
        }

        public static Bitmap ResizeImage(Image image)
        {
                int heightOriginal = image.Height;
                int widthOriginal = image.Width;
                var newHeight = image.Height * height / 786;
                var newWidth = image.Width * width / 1386;
                /*double locationX = inage.Location.X * propWidth;// + widthOriginal - p.Width;
                double locationY = p.Location.Y * propHeight;// + heightOriginal - p.Height;*/
                var destRect = new Rectangle(0, 0, newWidth, newHeight);
                var destImage = new Bitmap(newWidth, newHeight);

                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

            return destImage;
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
            int categoryprod = p.item.category;

            string descriptionprod = p.item.description;

            GroupBox currentGroupBox = new GroupBox();
            currentGroupBox.Size = new Size(756, 135); // definir tamanho do groupbox
            currentGroupBox.Location = new Point(3, 4 + i * 50 + i * 135);
            //adicionando imagens
            //REVER LÓGICA DE IMAGENS NULAS
            if (p == null)
            {
                
            }
            else if(p.assets[0] != null)
            {
                try
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
                    ReSize.pictureCrossBox(imagemProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
            estoque.Text = "Quantidade em estoque: " + p.item.stock.ToString();
            estoque.Size = new Size(190, 15);
            estoque.Location = new Point(276, 55); //localização do estoque
            currentGroupBox.Controls.Add(estoque);

            // atribuindo a categoria do produto
            Label categoria = new Label();
            categoria.Text = "Categoria: " + categorias.getCategoria(categoryprod);
            categoria.Size = new Size(190, 15);
            categoria.Location = new Point(487, 55); //localização da categoria
            currentGroupBox.Controls.Add(categoria);

            // atribuindo a descrição do produto
            Label descricao = new Label();
            descricao.Text = descriptionprod;
            descricao.Location = new Point(127, 80); //localização da categoria
            descricao.Size = new Size(580, 45);
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
            if (comboBoxAdicionarAtualizar.SelectedIndex == 0)
            {
                if (String.IsNullOrWhiteSpace(txtAdicionarNome.Text) || String.IsNullOrWhiteSpace(txtAdicionarValor.Text) || String.IsNullOrWhiteSpace(txtAdicionarQuant.Text) || comboBoxCategorias.SelectedIndex == 0 || String.IsNullOrWhiteSpace(txtAdicionarDescricao.Text))
                {
                    MessageBox.Show("Preencha todos os valores, não deixe nenhum campo vazio ou com apenas espaços!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        double preco = double.Parse(txtAdicionarValor.Text);
                        Item prod = new Item(txtAdicionarNome.Text, preco, int.Parse(txtAdicionarQuant.Text), comboBoxCategorias.SelectedIndex, txtAdicionarDescricao.Text);
                        string base64String;
                        Image img = ImagemEnviar;
                        using (img)
                        {
                            using (MemoryStream m = new MemoryStream())
                            {
                                img.Save(m, img.RawFormat);
                                byte[] imageBytes = m.ToArray();

                                // Convert byte[] to Base64 String
                                base64String = Convert.ToBase64String(imageBytes);

                            }
                            base64String = "data:image/jpeg;base64," + base64String;
                        }
                        MessageBox.Show(prod.price.ToString());
                        API.cadastrarNovoProduto(this.session.getJWT(), prod, base64String);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Os campos quantidade e valor exigem valores numéricos, sendo o valor sendo escrito 9999.99", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception teste)
                    {
                        MessageBox.Show(teste.ToString());
                    }
                }
            }
            else if(comboBoxAdicionarAtualizar.SelectedIndex == 1)
            {

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

        private void comboBoxAdicionarAtualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAdicionarAtualizar.SelectedIndex == 0)
            {
                labelEstoqueAdicionar.Text = "Adicionar Produto";
                txtAdicionarNome.Visible = true;
                comboBoxAtualizarItem.Visible = false;

            }
            else if (comboBoxAdicionarAtualizar.SelectedIndex == 1)
            {
                labelEstoqueAdicionar.Text = "Atualizar Produto";
                labelAdicionarNome.Text = "Produto";
                txtAdicionarNome.Visible = false;
                comboBoxAtualizarItem.Visible = true;
            }
        }

        private void comboBoxAtualizarItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdicionarQuant.Text = items.GetProdutos(comboBoxAdicionarAtualizar.SelectedIndex).item.stock.ToString();
            txtAdicionarValor.Text = items.GetProdutos(comboBoxAdicionarAtualizar.SelectedIndex).item.price.ToString();
            comboBoxCategorias.SelectedIndex = items.GetProdutos(comboBoxAdicionarAtualizar.SelectedIndex).item.category;
            txtAdicionarDescricao.Text = items.GetProdutos(comboBoxAdicionarAtualizar.SelectedIndex).item.description.ToString();
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(items.GetProdutos(comboBoxAdicionarAtualizar.SelectedIndex).assets[0]);
            MemoryStream ms = new MemoryStream(bytes);
            ImagemEnviar = System.Drawing.Image.FromStream(ms);
        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Achar foto!";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImagemEnviar = new Bitmap(dialog.OpenFile());
                    path = dialog.FileName;
                    MessageBox.Show(path);
                }
                catch (Exception er)
                {

                }
            }
        }

        private void changeComboBoxProducts()
        {

        }
    }
}



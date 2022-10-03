
namespace Starbuy_Desktop
{
    partial class FormEstoque
    {
        /// <summary>  
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.labelEstoqueCantoNome = new System.Windows.Forms.Label();
            this.gboxEstoquePerfil = new System.Windows.Forms.GroupBox();
            this.pictureBoxEstoqueCanto = new System.Windows.Forms.PictureBox();
            this.gboxEstoqueMenu = new System.Windows.Forms.GroupBox();
            this.pictureBoxEstoqueConfiguracoes = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstoquePedidos = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstoqueEstoque = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstoqueMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuVendedorCross = new System.Windows.Forms.PictureBox();
            this.labelEstoqueEstoque = new System.Windows.Forms.Label();
            this.groupBoxConfigAlterar = new System.Windows.Forms.GroupBox();
            this.txtAdicionarValor = new System.Windows.Forms.TextBox();
            this.labelAdicionarValor = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.labelAdicionarFoto = new System.Windows.Forms.Label();
            this.txtAdicionarFoto = new System.Windows.Forms.TextBox();
            this.labelAdicionarCategoria = new System.Windows.Forms.Label();
            this.labelAdicionarDescricao = new System.Windows.Forms.Label();
            this.labelAdicionarQuant = new System.Windows.Forms.Label();
            this.labelAdicionarNome = new System.Windows.Forms.Label();
            this.txtAdicionarCategoria = new System.Windows.Forms.TextBox();
            this.txtAdicionarDescricao = new System.Windows.Forms.TextBox();
            this.txtAdicionarQuant = new System.Windows.Forms.TextBox();
            this.txtAdicionarNome = new System.Windows.Forms.TextBox();
            this.labelEstoqueAdicionar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gboxEstoquePerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueCanto)).BeginInit();
            this.gboxEstoqueMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueConfiguracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoquePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuVendedorCross)).BeginInit();
            this.groupBoxConfigAlterar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEstoqueCantoNome
            // 
            this.labelEstoqueCantoNome.AutoSize = true;
            this.labelEstoqueCantoNome.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEstoqueCantoNome.Location = new System.Drawing.Point(16, 102);
            this.labelEstoqueCantoNome.Name = "labelEstoqueCantoNome";
            this.labelEstoqueCantoNome.Size = new System.Drawing.Size(119, 32);
            this.labelEstoqueCantoNome.TabIndex = 4;
            this.labelEstoqueCantoNome.Text = "Vendedor";
            // 
            // gboxEstoquePerfil
            // 
            this.gboxEstoquePerfil.Controls.Add(this.pictureBoxEstoqueCanto);
            this.gboxEstoquePerfil.Controls.Add(this.labelEstoqueCantoNome);
            this.gboxEstoquePerfil.Location = new System.Drawing.Point(0, -7);
            this.gboxEstoquePerfil.Name = "gboxEstoquePerfil";
            this.gboxEstoquePerfil.Size = new System.Drawing.Size(223, 147);
            this.gboxEstoquePerfil.TabIndex = 5;
            this.gboxEstoquePerfil.TabStop = false;
            // 
            // pictureBoxEstoqueCanto
            // 
            this.pictureBoxEstoqueCanto.Location = new System.Drawing.Point(16, 38);
            this.pictureBoxEstoqueCanto.Name = "pictureBoxEstoqueCanto";
            this.pictureBoxEstoqueCanto.Size = new System.Drawing.Size(57, 51);
            this.pictureBoxEstoqueCanto.TabIndex = 26;
            this.pictureBoxEstoqueCanto.TabStop = false;
            // 
            // gboxEstoqueMenu
            // 
            this.gboxEstoqueMenu.Controls.Add(this.pictureBoxEstoqueConfiguracoes);
            this.gboxEstoqueMenu.Controls.Add(this.pictureBoxEstoquePedidos);
            this.gboxEstoqueMenu.Controls.Add(this.pictureBoxEstoqueEstoque);
            this.gboxEstoqueMenu.Controls.Add(this.pictureBoxEstoqueMenu);
            this.gboxEstoqueMenu.Location = new System.Drawing.Point(0, 145);
            this.gboxEstoqueMenu.Name = "gboxEstoqueMenu";
            this.gboxEstoqueMenu.Size = new System.Drawing.Size(223, 640);
            this.gboxEstoqueMenu.TabIndex = 6;
            this.gboxEstoqueMenu.TabStop = false;
            // 
            // pictureBoxEstoqueConfiguracoes
            // 
            this.pictureBoxEstoqueConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstoqueConfiguracoes.Image")));
            this.pictureBoxEstoqueConfiguracoes.Location = new System.Drawing.Point(0, 141);
            this.pictureBoxEstoqueConfiguracoes.Name = "pictureBoxEstoqueConfiguracoes";
            this.pictureBoxEstoqueConfiguracoes.Size = new System.Drawing.Size(217, 38);
            this.pictureBoxEstoqueConfiguracoes.TabIndex = 9;
            this.pictureBoxEstoqueConfiguracoes.TabStop = false;
            this.pictureBoxEstoqueConfiguracoes.Click += new System.EventHandler(this.pictureBoxEstoqueConfiguracoes_Click);
            // 
            // pictureBoxEstoquePedidos
            // 
            this.pictureBoxEstoquePedidos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstoquePedidos.Image")));
            this.pictureBoxEstoquePedidos.Location = new System.Drawing.Point(0, 97);
            this.pictureBoxEstoquePedidos.Name = "pictureBoxEstoquePedidos";
            this.pictureBoxEstoquePedidos.Size = new System.Drawing.Size(217, 38);
            this.pictureBoxEstoquePedidos.TabIndex = 8;
            this.pictureBoxEstoquePedidos.TabStop = false;
            this.pictureBoxEstoquePedidos.Click += new System.EventHandler(this.pictureBoxEstoquePedidos_Click);
            // 
            // pictureBoxEstoqueEstoque
            // 
            this.pictureBoxEstoqueEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstoqueEstoque.Image")));
            this.pictureBoxEstoqueEstoque.Location = new System.Drawing.Point(0, 53);
            this.pictureBoxEstoqueEstoque.Name = "pictureBoxEstoqueEstoque";
            this.pictureBoxEstoqueEstoque.Size = new System.Drawing.Size(223, 38);
            this.pictureBoxEstoqueEstoque.TabIndex = 7;
            this.pictureBoxEstoqueEstoque.TabStop = false;
            // 
            // pictureBoxEstoqueMenu
            // 
            this.pictureBoxEstoqueMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEstoqueMenu.Image")));
            this.pictureBoxEstoqueMenu.Location = new System.Drawing.Point(0, 9);
            this.pictureBoxEstoqueMenu.Name = "pictureBoxEstoqueMenu";
            this.pictureBoxEstoqueMenu.Size = new System.Drawing.Size(217, 38);
            this.pictureBoxEstoqueMenu.TabIndex = 6;
            this.pictureBoxEstoqueMenu.TabStop = false;
            this.pictureBoxEstoqueMenu.Click += new System.EventHandler(this.pictureBoxEstoqueMenu_Click);
            // 
            // pictureBoxMenuVendedorCross
            // 
            this.pictureBoxMenuVendedorCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenuVendedorCross.Image")));
            this.pictureBoxMenuVendedorCross.Location = new System.Drawing.Point(1310, 30);
            this.pictureBoxMenuVendedorCross.Name = "pictureBoxMenuVendedorCross";
            this.pictureBoxMenuVendedorCross.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxMenuVendedorCross.TabIndex = 14;
            this.pictureBoxMenuVendedorCross.TabStop = false;
            this.pictureBoxMenuVendedorCross.Click += new System.EventHandler(this.pictureBoxEstoqueMenuVendedorCross_Click);
            // 
            // labelEstoqueEstoque
            // 
            this.labelEstoqueEstoque.AutoSize = true;
            this.labelEstoqueEstoque.BackColor = System.Drawing.Color.Transparent;
            this.labelEstoqueEstoque.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstoqueEstoque.Location = new System.Drawing.Point(587, 30);
            this.labelEstoqueEstoque.Name = "labelEstoqueEstoque";
            this.labelEstoqueEstoque.Size = new System.Drawing.Size(105, 32);
            this.labelEstoqueEstoque.TabIndex = 28;
            this.labelEstoqueEstoque.Text = "Estoque";
            // 
            // groupBoxConfigAlterar
            // 
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarValor);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarValor);
            this.groupBoxConfigAlterar.Controls.Add(this.btnAdicionar);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarFoto);
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarFoto);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarCategoria);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarDescricao);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarQuant);
            this.groupBoxConfigAlterar.Controls.Add(this.labelAdicionarNome);
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarCategoria);
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarDescricao);
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarQuant);
            this.groupBoxConfigAlterar.Controls.Add(this.txtAdicionarNome);
            this.groupBoxConfigAlterar.Controls.Add(this.labelEstoqueAdicionar);
            this.groupBoxConfigAlterar.Location = new System.Drawing.Point(1048, 65);
            this.groupBoxConfigAlterar.Name = "groupBoxConfigAlterar";
            this.groupBoxConfigAlterar.Size = new System.Drawing.Size(262, 695);
            this.groupBoxConfigAlterar.TabIndex = 29;
            this.groupBoxConfigAlterar.TabStop = false;
            // 
            // txtAdicionarValor
            // 
            this.txtAdicionarValor.Location = new System.Drawing.Point(15, 267);
            this.txtAdicionarValor.Multiline = true;
            this.txtAdicionarValor.Name = "txtAdicionarValor";
            this.txtAdicionarValor.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarValor.TabIndex = 19;
            // 
            // labelAdicionarValor
            // 
            this.labelAdicionarValor.AutoSize = true;
            this.labelAdicionarValor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarValor.Location = new System.Drawing.Point(15, 234);
            this.labelAdicionarValor.Name = "labelAdicionarValor";
            this.labelAdicionarValor.Size = new System.Drawing.Size(238, 25);
            this.labelAdicionarValor.TabIndex = 18;
            this.labelAdicionarValor.Text = "Valor a ser comercializado:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(24, 599);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(209, 33);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // labelAdicionarFoto
            // 
            this.labelAdicionarFoto.AutoSize = true;
            this.labelAdicionarFoto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarFoto.Location = new System.Drawing.Point(15, 509);
            this.labelAdicionarFoto.Name = "labelAdicionarFoto";
            this.labelAdicionarFoto.Size = new System.Drawing.Size(153, 25);
            this.labelAdicionarFoto.TabIndex = 16;
            this.labelAdicionarFoto.Text = "Foto do produto:";
            // 
            // txtAdicionarFoto
            // 
            this.txtAdicionarFoto.Location = new System.Drawing.Point(15, 537);
            this.txtAdicionarFoto.Multiline = true;
            this.txtAdicionarFoto.Name = "txtAdicionarFoto";
            this.txtAdicionarFoto.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarFoto.TabIndex = 15;
            // 
            // labelAdicionarCategoria
            // 
            this.labelAdicionarCategoria.AutoSize = true;
            this.labelAdicionarCategoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarCategoria.Location = new System.Drawing.Point(15, 419);
            this.labelAdicionarCategoria.Name = "labelAdicionarCategoria";
            this.labelAdicionarCategoria.Size = new System.Drawing.Size(98, 25);
            this.labelAdicionarCategoria.TabIndex = 14;
            this.labelAdicionarCategoria.Text = "Categoria:";
            // 
            // labelAdicionarDescricao
            // 
            this.labelAdicionarDescricao.AutoSize = true;
            this.labelAdicionarDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarDescricao.Location = new System.Drawing.Point(15, 329);
            this.labelAdicionarDescricao.Name = "labelAdicionarDescricao";
            this.labelAdicionarDescricao.Size = new System.Drawing.Size(98, 25);
            this.labelAdicionarDescricao.TabIndex = 13;
            this.labelAdicionarDescricao.Text = "Descrição:";
            // 
            // labelAdicionarQuant
            // 
            this.labelAdicionarQuant.AutoSize = true;
            this.labelAdicionarQuant.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarQuant.Location = new System.Drawing.Point(15, 154);
            this.labelAdicionarQuant.Name = "labelAdicionarQuant";
            this.labelAdicionarQuant.Size = new System.Drawing.Size(218, 25);
            this.labelAdicionarQuant.TabIndex = 11;
            this.labelAdicionarQuant.Text = "Quantidade em estoque:";
            // 
            // labelAdicionarNome
            // 
            this.labelAdicionarNome.AutoSize = true;
            this.labelAdicionarNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdicionarNome.Location = new System.Drawing.Point(15, 70);
            this.labelAdicionarNome.Name = "labelAdicionarNome";
            this.labelAdicionarNome.Size = new System.Drawing.Size(67, 25);
            this.labelAdicionarNome.TabIndex = 10;
            this.labelAdicionarNome.Text = "Nome:";
            // 
            // txtAdicionarCategoria
            // 
            this.txtAdicionarCategoria.Location = new System.Drawing.Point(15, 447);
            this.txtAdicionarCategoria.Multiline = true;
            this.txtAdicionarCategoria.Name = "txtAdicionarCategoria";
            this.txtAdicionarCategoria.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarCategoria.TabIndex = 9;
            // 
            // txtAdicionarDescricao
            // 
            this.txtAdicionarDescricao.Location = new System.Drawing.Point(15, 357);
            this.txtAdicionarDescricao.Multiline = true;
            this.txtAdicionarDescricao.Name = "txtAdicionarDescricao";
            this.txtAdicionarDescricao.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarDescricao.TabIndex = 8;
            // 
            // txtAdicionarQuant
            // 
            this.txtAdicionarQuant.Location = new System.Drawing.Point(15, 182);
            this.txtAdicionarQuant.Multiline = true;
            this.txtAdicionarQuant.Name = "txtAdicionarQuant";
            this.txtAdicionarQuant.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarQuant.TabIndex = 6;
            // 
            // txtAdicionarNome
            // 
            this.txtAdicionarNome.Location = new System.Drawing.Point(15, 98);
            this.txtAdicionarNome.Multiline = true;
            this.txtAdicionarNome.Name = "txtAdicionarNome";
            this.txtAdicionarNome.Size = new System.Drawing.Size(227, 40);
            this.txtAdicionarNome.TabIndex = 1;
            // 
            // labelEstoqueAdicionar
            // 
            this.labelEstoqueAdicionar.AutoSize = true;
            this.labelEstoqueAdicionar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEstoqueAdicionar.Location = new System.Drawing.Point(26, 19);
            this.labelEstoqueAdicionar.Name = "labelEstoqueAdicionar";
            this.labelEstoqueAdicionar.Size = new System.Drawing.Size(207, 32);
            this.labelEstoqueAdicionar.TabIndex = 0;
            this.labelEstoqueAdicionar.Text = "Adicionar produto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(246, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 676);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Página:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anterior";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Próxima";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxConfigAlterar);
            this.Controls.Add(this.labelEstoqueEstoque);
            this.Controls.Add(this.pictureBoxMenuVendedorCross);
            this.Controls.Add(this.gboxEstoqueMenu);
            this.Controls.Add(this.gboxEstoquePerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            this.gboxEstoquePerfil.ResumeLayout(false);
            this.gboxEstoquePerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueCanto)).EndInit();
            this.gboxEstoqueMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueConfiguracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoquePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuVendedorCross)).EndInit();
            this.groupBoxConfigAlterar.ResumeLayout(false);
            this.groupBoxConfigAlterar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstoqueCantoNome;
        private System.Windows.Forms.GroupBox gboxEstoquePerfil;
        private System.Windows.Forms.GroupBox gboxEstoqueMenu;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueCanto;
        private System.Windows.Forms.PictureBox pictureBoxMenuVendedorCross;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueMenu;
        private System.Windows.Forms.PictureBox pictureBoxEstoquePedidos;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueConfiguracoes;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueEstoque;
        private System.Windows.Forms.Label labelEstoqueEstoque;
        private System.Windows.Forms.GroupBox groupBoxConfigAlterar;
        private System.Windows.Forms.Label labelAdicionarValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label labelAdicionarCategoria;
        private System.Windows.Forms.Label labelAdicionarDescricao;
        private System.Windows.Forms.Label labelAdicionarQuant;
        private System.Windows.Forms.Label labelAdicionarNome;
        private System.Windows.Forms.TextBox txtAdicionarCategoria;
        private System.Windows.Forms.TextBox txtAdicionarDescricao;
        private System.Windows.Forms.TextBox txtAdicionarNome;
        private System.Windows.Forms.Label labelEstoqueAdicionar;
        private System.Windows.Forms.Label labelAdicionarFoto;
        private System.Windows.Forms.TextBox txtAdicionarFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAdicionarValor;
        private System.Windows.Forms.TextBox txtAdicionarQuant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
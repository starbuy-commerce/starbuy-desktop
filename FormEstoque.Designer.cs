
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
            this.groupBoxPainelEstoque = new System.Windows.Forms.GroupBox();
            this.pictureBoxMenuVendedorCross = new System.Windows.Forms.PictureBox();
            this.labelEstoqueEstoque = new System.Windows.Forms.Label();
            this.gboxEstoquePerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueCanto)).BeginInit();
            this.gboxEstoqueMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueConfiguracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoquePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstoqueMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuVendedorCross)).BeginInit();
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
            // groupBoxPainelEstoque
            // 
            this.groupBoxPainelEstoque.Location = new System.Drawing.Point(256, 95);
            this.groupBoxPainelEstoque.Name = "groupBoxPainelEstoque";
            this.groupBoxPainelEstoque.Size = new System.Drawing.Size(1048, 664);
            this.groupBoxPainelEstoque.TabIndex = 7;
            this.groupBoxPainelEstoque.TabStop = false;
            this.groupBoxPainelEstoque.Enter += new System.EventHandler(this.groupBoxPainelEstoque_Enter);
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
            this.labelEstoqueEstoque.Location = new System.Drawing.Point(737, 41);
            this.labelEstoqueEstoque.Name = "labelEstoqueEstoque";
            this.labelEstoqueEstoque.Size = new System.Drawing.Size(105, 32);
            this.labelEstoqueEstoque.TabIndex = 28;
            this.labelEstoqueEstoque.Text = "Estoque";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.labelEstoqueEstoque);
            this.Controls.Add(this.pictureBoxMenuVendedorCross);
            this.Controls.Add(this.groupBoxPainelEstoque);
            this.Controls.Add(this.gboxEstoqueMenu);
            this.Controls.Add(this.gboxEstoquePerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstoqueCantoNome;
        private System.Windows.Forms.GroupBox gboxEstoquePerfil;
        private System.Windows.Forms.GroupBox gboxEstoqueMenu;
        private System.Windows.Forms.GroupBox groupBoxPainelEstoque;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueCanto;
        private System.Windows.Forms.PictureBox pictureBoxMenuVendedorCross;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueMenu;
        private System.Windows.Forms.PictureBox pictureBoxEstoquePedidos;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueConfiguracoes;
        private System.Windows.Forms.PictureBox pictureBoxEstoqueEstoque;
        private System.Windows.Forms.Label labelEstoqueEstoque;
    }
}
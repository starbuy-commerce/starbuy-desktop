
namespace Starbuy_Desktop
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.labelRegistroRegistre = new System.Windows.Forms.Label();
            this.textBoxRegistroNome = new System.Windows.Forms.TextBox();
            this.textBoxLoginLinha1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRegistroRegistre
            // 
            this.labelRegistroRegistre.AutoSize = true;
            this.labelRegistroRegistre.Font = new System.Drawing.Font("Ebrima", 85F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegistroRegistre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.labelRegistroRegistre.Location = new System.Drawing.Point(37, 34);
            this.labelRegistroRegistre.Name = "labelRegistroRegistre";
            this.labelRegistroRegistre.Size = new System.Drawing.Size(662, 152);
            this.labelRegistroRegistre.TabIndex = 3;
            this.labelRegistroRegistre.Text = "Registre-se";
            // 
            // textBoxRegistroNome
            // 
            this.textBoxRegistroNome.BackColor = System.Drawing.Color.White;
            this.textBoxRegistroNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistroNome.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRegistroNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegistroNome.Location = new System.Drawing.Point(65, 240);
            this.textBoxRegistroNome.Name = "textBoxRegistroNome";
            this.textBoxRegistroNome.PlaceholderText = "Nome";
            this.textBoxRegistroNome.Size = new System.Drawing.Size(617, 45);
            this.textBoxRegistroNome.TabIndex = 6;
            // 
            // textBoxLoginLinha1
            // 
            this.textBoxLoginLinha1.BackColor = System.Drawing.Color.White;
            this.textBoxLoginLinha1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginLinha1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginLinha1.ForeColor = System.Drawing.Color.Black;
            this.textBoxLoginLinha1.Location = new System.Drawing.Point(65, 252);
            this.textBoxLoginLinha1.Name = "textBoxLoginLinha1";
            this.textBoxLoginLinha1.Size = new System.Drawing.Size(617, 45);
            this.textBoxLoginLinha1.TabIndex = 7;
            this.textBoxLoginLinha1.Text = "____________________________________________";
            this.textBoxLoginLinha1.TextChanged += new System.EventHandler(this.textBoxLoginLinha1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(65, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Usuário";
            this.textBox1.Size = new System.Drawing.Size(617, 45);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(65, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(617, 45);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "____________________________________________";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1408, 909);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxRegistroNome);
            this.Controls.Add(this.labelRegistroRegistre);
            this.Controls.Add(this.textBoxLoginLinha1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Registrar-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistroRegistre;
        private System.Windows.Forms.TextBox textBoxRegistroNome;
        private System.Windows.Forms.TextBox textBoxLoginLinha1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
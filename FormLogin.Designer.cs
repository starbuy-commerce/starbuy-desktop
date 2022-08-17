
namespace Starbuy_Desktop
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelLoginBemVindo = new System.Windows.Forms.Label();
            this.labelLoginA = new System.Windows.Forms.Label();
            this.labelLoginStarbuy = new System.Windows.Forms.Label();
            this.labelLoginFacaConta = new System.Windows.Forms.Label();
            this.labelLoginRegistrese = new System.Windows.Forms.Label();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelLoginEsqueceu = new System.Windows.Forms.Label();
            this.buttonLoginEntrar = new System.Windows.Forms.Button();
            this.pictureBoxLoginCross = new System.Windows.Forms.PictureBox();
            this.labelLinha1 = new System.Windows.Forms.Label();
            this.labelLinha2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginCross)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginBemVindo
            // 
            this.labelLoginBemVindo.AutoSize = true;
            this.labelLoginBemVindo.Font = new System.Drawing.Font("Ebrima", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginBemVindo.Location = new System.Drawing.Point(21, 26);
            this.labelLoginBemVindo.Name = "labelLoginBemVindo";
            this.labelLoginBemVindo.Size = new System.Drawing.Size(783, 106);
            this.labelLoginBemVindo.TabIndex = 0;
            this.labelLoginBemVindo.Text = "Bem-vindo de volta";
            // 
            // labelLoginA
            // 
            this.labelLoginA.AutoSize = true;
            this.labelLoginA.Font = new System.Drawing.Font("Ebrima", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginA.Location = new System.Drawing.Point(36, 150);
            this.labelLoginA.Name = "labelLoginA";
            this.labelLoginA.Size = new System.Drawing.Size(88, 106);
            this.labelLoginA.TabIndex = 1;
            this.labelLoginA.Text = "à";
            // 
            // labelLoginStarbuy
            // 
            this.labelLoginStarbuy.AutoSize = true;
            this.labelLoginStarbuy.Font = new System.Drawing.Font("Ebrima", 85F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginStarbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.labelLoginStarbuy.Location = new System.Drawing.Point(90, 115);
            this.labelLoginStarbuy.Name = "labelLoginStarbuy";
            this.labelLoginStarbuy.Size = new System.Drawing.Size(516, 152);
            this.labelLoginStarbuy.TabIndex = 2;
            this.labelLoginStarbuy.Text = "Starbuy!";
            // 
            // labelLoginFacaConta
            // 
            this.labelLoginFacaConta.AutoSize = true;
            this.labelLoginFacaConta.Font = new System.Drawing.Font("Ebrima", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginFacaConta.Location = new System.Drawing.Point(36, 305);
            this.labelLoginFacaConta.Name = "labelLoginFacaConta";
            this.labelLoginFacaConta.Size = new System.Drawing.Size(741, 51);
            this.labelLoginFacaConta.TabIndex = 3;
            this.labelLoginFacaConta.Text = "Faça login com a sua conta! Não tem uma?";
            // 
            // labelLoginRegistrese
            // 
            this.labelLoginRegistrese.AutoSize = true;
            this.labelLoginRegistrese.Font = new System.Drawing.Font("Ebrima", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginRegistrese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.labelLoginRegistrese.Location = new System.Drawing.Point(769, 305);
            this.labelLoginRegistrese.Name = "labelLoginRegistrese";
            this.labelLoginRegistrese.Size = new System.Drawing.Size(220, 51);
            this.labelLoginRegistrese.TabIndex = 4;
            this.labelLoginRegistrese.Text = "Registre-se!";
            this.labelLoginRegistrese.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.registerFormsOpen);
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.BackColor = System.Drawing.Color.White;
            this.textBoxLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginUsername.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginUsername.Location = new System.Drawing.Point(45, 449);
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.PlaceholderText = "Digite o seu username";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(617, 45);
            this.textBoxLoginUsername.TabIndex = 5;
            this.textBoxLoginUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginUsername_KeyPress);
            // 
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.BackColor = System.Drawing.Color.White;
            this.textBoxLoginSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginSenha.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginSenha.Location = new System.Drawing.Point(45, 562);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.PlaceholderText = "Digite a sua senha";
            this.textBoxLoginSenha.Size = new System.Drawing.Size(617, 45);
            this.textBoxLoginSenha.TabIndex = 7;
            this.textBoxLoginSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginSenha_KeyPress);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(820, 273);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(524, 551);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 9;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // labelLoginEsqueceu
            // 
            this.labelLoginEsqueceu.AutoSize = true;
            this.labelLoginEsqueceu.Font = new System.Drawing.Font("Ebrima", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginEsqueceu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(0)))));
            this.labelLoginEsqueceu.Location = new System.Drawing.Point(36, 632);
            this.labelLoginEsqueceu.Name = "labelLoginEsqueceu";
            this.labelLoginEsqueceu.Size = new System.Drawing.Size(336, 51);
            this.labelLoginEsqueceu.TabIndex = 10;
            this.labelLoginEsqueceu.Text = "Esqueceu a senha?";
            // 
            // buttonLoginEntrar
            // 
            this.buttonLoginEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.buttonLoginEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLoginEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginEntrar.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoginEntrar.ForeColor = System.Drawing.Color.White;
            this.buttonLoginEntrar.Location = new System.Drawing.Point(45, 698);
            this.buttonLoginEntrar.Name = "buttonLoginEntrar";
            this.buttonLoginEntrar.Size = new System.Drawing.Size(474, 55);
            this.buttonLoginEntrar.TabIndex = 11;
            this.buttonLoginEntrar.Text = "Entrar";
            this.buttonLoginEntrar.UseVisualStyleBackColor = false;
            this.buttonLoginEntrar.Click += new System.EventHandler(this.buttonLoginEntrar_Click);
            // 
            // pictureBoxLoginCross
            // 
            this.pictureBoxLoginCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginCross.Image")));
            this.pictureBoxLoginCross.Location = new System.Drawing.Point(1311, 26);
            this.pictureBoxLoginCross.Name = "pictureBoxLoginCross";
            this.pictureBoxLoginCross.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxLoginCross.TabIndex = 12;
            this.pictureBoxLoginCross.TabStop = false;
            this.pictureBoxLoginCross.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLoginCross_MouseClick);
            // 
            // labelLinha1
            // 
            this.labelLinha1.AutoSize = true;
            this.labelLinha1.Font = new System.Drawing.Font("Ebrima", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLinha1.Location = new System.Drawing.Point(36, 459);
            this.labelLinha1.Name = "labelLinha1";
            this.labelLinha1.Size = new System.Drawing.Size(582, 51);
            this.labelLinha1.TabIndex = 13;
            this.labelLinha1.Text = "___________________________________";
            // 
            // labelLinha2
            // 
            this.labelLinha2.AutoSize = true;
            this.labelLinha2.Font = new System.Drawing.Font("Ebrima", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLinha2.Location = new System.Drawing.Point(36, 571);
            this.labelLinha2.Name = "labelLinha2";
            this.labelLinha2.Size = new System.Drawing.Size(582, 51);
            this.labelLinha2.TabIndex = 14;
            this.labelLinha2.Text = "___________________________________";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBoxLoginCross);
            this.Controls.Add(this.buttonLoginEntrar);
            this.Controls.Add(this.labelLoginEsqueceu);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.textBoxLoginUsername);
            this.Controls.Add(this.labelLoginRegistrese);
            this.Controls.Add(this.labelLoginFacaConta);
            this.Controls.Add(this.labelLoginStarbuy);
            this.Controls.Add(this.labelLoginA);
            this.Controls.Add(this.labelLoginBemVindo);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.labelLinha1);
            this.Controls.Add(this.labelLinha2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginBemVindo;
        private System.Windows.Forms.Label labelLoginA;
        private System.Windows.Forms.Label labelLoginStarbuy;
        private System.Windows.Forms.Label labelLoginFacaConta;
        private System.Windows.Forms.Label labelLoginRegistrese;
        private System.Windows.Forms.TextBox textBoxLoginUsername;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelLoginEsqueceu;
        private System.Windows.Forms.Button buttonLoginEntrar;
        private System.Windows.Forms.PictureBox pictureBoxLoginCross;
        private System.Windows.Forms.Label labelLinha1;
        private System.Windows.Forms.Label labelLinha2;
    }
}


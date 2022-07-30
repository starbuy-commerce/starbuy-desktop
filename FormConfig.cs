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


namespace Starbuy_Desktop
{
    
public partial class FormConfig : Form {

        private Usuario user;

        public FormConfig() {
            this.user = Session.getSession().getUser();
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e) {
            labelConfigCantoNome.Text = user.name;
            labelConfigNome.Text = user.name;
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(user.profile_picture);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            System.Drawing.Image resizeSmall = (new Bitmap(img, 57, 51));
            pictureBoxConfigCanto.Image = resizeSmall;
            System.Drawing.Image resizeProfile = (new Bitmap(img, 165, 162));
            pictureBoxConfigFoto.Image = resizeProfile;
        }

        private void pictureBoxMenuVendedorCross_Click(object sender, EventArgs e) {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes) {
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void pictureBoxConfigMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void pictureBoxConfigPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPedidos pedidos = new FormPedidos();
            pedidos.Show();
        }

        private void pictureBoxConfigEstoque_Click(object sender, EventArgs e) {
            /*FormEstoque estoque = new FormEstoque();
            estoque.Show(); //criar forms de estoque */
        }
    }
}

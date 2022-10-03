using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Starbuy_Desktop
{
    public partial class FormRegistro : Form
    {
        ToolTip toolTipDate = new ToolTip();
        int verificaData = 0;
        String path;
        public FormRegistro()
        {
            InitializeComponent();
            ReSize.buttonResize(btnArquivo);
            ReSize.buttonResize(buttonRegistro);

            ReSize.labelResize(lblEscolhaImagem);
            ReSize.labelResize(labelLinha1);
            ReSize.labelResize(labelLinha2);
            ReSize.labelResize(labelLinha3);
            ReSize.labelResize(labelLinha4);
            ReSize.labelResize(labelLinha5);
            ReSize.labelResize(labelLinha6);
            ReSize.labelResize(labelLinha7);
            ReSize.labelResize(labelLinha8);
            ReSize.labelResize(labelLinha9);
            ReSize.labelResize(labelLinha10);
            ReSize.labelResize(labelRegistroRegistre);
            ReSize.textBoxResize(textBoxRegistroUsuario);
            ReSize.textBoxResize(textBoxRegistroCidade);
            ReSize.textBoxResize(textBoxRegistroConfirmar);
            ReSize.textBoxResize(textBoxRegistroEmail);
            ReSize.textBoxResize(textBoxRegistroEndereco);
            ReSize.textBoxResize(textBoxRegistroNome);
            ReSize.textBoxResize(textBoxRegistroNumero);
            ReSize.textBoxResize(textBoxRegistroSenha);
            ReSize.maskedResize(maskedTextBoxRegistroCEP);
            ReSize.maskedResize(maskedTextBoxRegistroNascimento);
        }

        private void pictureBoxRegistroCross_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Deseja fechar o aplicativo e retornar a tela de login?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diag == DialogResult.Yes)
            {
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
            }
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRegistroNome.Text) || !maskedTextBoxRegistroCEP.MaskCompleted || String.IsNullOrEmpty(textBoxRegistroUsuario.Text) || String.IsNullOrEmpty(textBoxRegistroEmail.Text) || String.IsNullOrEmpty(textBoxRegistroSenha.Text) || String.IsNullOrEmpty(textBoxRegistroConfirmar.Text) 
                || !maskedTextBoxRegistroNascimento.MaskCompleted || String.IsNullOrEmpty(textBoxRegistroEndereco.Text) || String.IsNullOrEmpty(textBoxRegistroCidade.Text) ||
                    String.IsNullOrEmpty(textBoxRegistroNumero.Text) || String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Preencha todos os valores!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if(textBoxRegistroSenha.Text == textBoxRegistroConfirmar.Text)
                {
                    try
                    {
                        if (verificaData == 0)
                        {
                            String num = textBoxRegistroNumero.Text.ToString();
                            int numero;
                           
                            if (int.TryParse(num.ToString(), out numero))
                            {
                                String cep = maskedTextBoxRegistroCEP.Text.ToString();
                                MessageBox.Show(cep.ToString());
                                String textBoxNascimento = maskedTextBoxRegistroNascimento.Text.ToString();
                                String []dataDeNascimento = textBoxNascimento.Split("/");
                                String requestBirthdate = "";
                                for (int i = 2; i >= 0; i--){
                                    if (i == 2){ requestBirthdate = dataDeNascimento[i].ToString(); }
                                    else { 
                                    requestBirthdate = requestBirthdate + "-" + dataDeNascimento[i].ToString();}
                                }
                                MessageBox.Show(requestBirthdate.ToString());
                                var rq = new RequestCadastro(textBoxRegistroNome.Text, textBoxRegistroNome.Text.ToString(), textBoxRegistroEmail.Text.ToString(), textBoxRegistroCidade.Text.ToString(), requestBirthdate, textBoxRegistroSenha.Text.ToString()); ;
                                API.cadastrar(rq);
                                //MessageBox.Show(ResponseCadastro.getResponseCadastro().message);
                            }
                            else
                            {
                                MessageBox.Show("Não pode transformar letras em números!");
                            }
                        }
                        else {MessageBox.Show("A data não está correta, siga as dicas!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    catch(Exception excecao)
                    {
                        MessageBox.Show(excecao.Message);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            maskedTextBoxRegistroNascimento.Mask = "00/00/0000";
            maskedTextBoxRegistroNascimento.ValidatingType = typeof(System.DateTime);
            maskedTextBoxRegistroNascimento.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox1_TypeValidationCompleted);
            maskedTextBoxRegistroNascimento.KeyDown += new KeyEventHandler(maskedTextBoxRegistroNascimento_KeyDown);
            toolTipDate.IsBalloon = true;
        }

        void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTipDate.ToolTipTitle = "Data inválida";
                toolTipDate.Show("Você deve digitar um valor dentre os padrões de data!", maskedTextBoxRegistroNascimento, 0, -60, 4000);
                verificaData = 2;
            }
            else
            {
                DateTime minimum =  new DateTime(01 / 01 / 1900);
                DateTime maximum = (DateTime.Now);
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate < minimum || userDate > maximum)
                {
                    toolTipDate.ToolTipTitle = "Data de nascimento inválida!";
                    toolTipDate.Show("A data deve estar entre 01/01/1900 e " + maximum.ToString(), maskedTextBoxRegistroNascimento,0, -20, 5000);
                    e.Cancel = true;
                    verificaData = 1;
                }
                else
                {
                    verificaData = 0;
                }
            }
        }

        private void maskedTextBoxRegistroNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipDate.Hide(maskedTextBoxRegistroNascimento);
        }

        private void maskedTextBoxRegistroNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Achar foto!";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = dialog.OpenFile();
                    path = dialog.FileName;
                    MessageBox.Show(path);
                }
                catch (Exception er)
                {

                }
            }
        }
    }
}
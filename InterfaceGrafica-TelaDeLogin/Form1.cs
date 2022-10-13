using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                buttonCancelar.PerformClick();
            }
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsuario.Text.Equals("calendario") && textBoxSenha.Text.Equals("abc123"))
                {
                    MessageBox.Show("Acesso autorizado", "Seja bem vindo!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado. Por favor, reinicie o programa.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }

        private void ButtonEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonEntrar.PerformClick();
            }
        }

        private void TextBoxUsuario_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Clear();
        }

        private void TextBoxSenha_Click(object sender, EventArgs e)
        {
            textBoxSenha.Clear();
        } 
    }
}

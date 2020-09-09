using System;
using System.Windows.Forms;
using testePratico.DAL;
using testePratico.Lib;
using testePratico.Model;

namespace testePratico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LimpaTXT();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = LoginDAL.buscarUsuario(txtUsuario.Text, txtSenha.Text);

            if (user == null)
            {
                MessageBox.Show("Usuário ou Senha invalidos. Verifique.");
                LimpaTXT();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                GlobalVars.User_Nome = user.Nome;
                Close();
            }
        }

        private void LimpaTXT()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            TestePraticoEntities conn = new TestePraticoEntities();
            Usuario user = conn.Usuarios.Where(u => u.Login == txtUsuario.Text.Trim() && u.Senha == txtSenha.Text.Trim()).Select(x => x).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Usuário e senha invalidos. Verifique.");
                LimpaTXT();
            }
            else{
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

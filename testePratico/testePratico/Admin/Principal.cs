using System;
using System.Linq;
using System.Windows.Forms;
using testePratico.Cadastros;
using testePratico.Lib;
using testePratico.Model;

namespace testePratico.Admin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            sbUsuario.Text = GlobalVars.User_Nome;
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores tela = new Fornecedores();

            if (Application.OpenForms.OfType<Fornecedores>().Count() == 0)
            {
                tela.MdiParent = this;
                tela.Show();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos tela = new Produtos();
            if (Application.OpenForms.OfType<Produtos>().Count() == 0)
            {
                tela.MdiParent = this;
                tela.Show();
            }
        }
    }
}

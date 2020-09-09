using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (Application.OpenForms.OfType<Fornecedores>().Count() == 0)
            {
                Fornecedores tela = new Fornecedores();
                tela.MdiParent = this;
                tela.Show();
            }
        }
    }
}

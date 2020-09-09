using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testePratico.Model;

namespace testePratico.Cadastros
{
    public partial class Fornecedores : Form
    {
        private int iFornecedorID = 0;

        public Fornecedores()
        {
            InitializeComponent();
        }

        private void Fornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabConsulta;
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            TestePraticoEntities conn = new TestePraticoEntities();
            var lista = conn.Fornecedors.Select(f => f).OrderBy(f => f.Nome).ToList();
            dbGrid.DataSource = lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabCadastro;
            iFornecedorID = 0;
            LimpaTXT();
        }

        private void LimpaTXT()
        {
            txtNome.Clear();
            txtCNPJ.Clear();
            txtEndereco.Clear();
            chkAtivo.Checked = false;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TestePraticoEntities conn = new TestePraticoEntities();
            Fornecedor fornecedor = new Fornecedor();

            if (iFornecedorID != 0)
            {
                fornecedor = conn.Fornecedors.Where(f => f.FornecedorID == iFornecedorID).Select(f => f).FirstOrDefault();
            }

            Fornecedor forn = new Fornecedor();
            forn.Nome = txtNome.Text.Trim();
            forn.CNPJ = txtCNPJ.Text.Trim();
            forn.Endereco = txtEndereco.Text.Trim();
            forn.isAtivo = chkAtivo.Checked == true ? true : false;

            if (iFornecedorID == 0)
               conn.Fornecedors.Add(forn);

            conn.SaveChanges();

            LimpaTXT();
            CarregarGrid();
            tabControl.SelectedTab = tabConsulta;
        }

        private void dbGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}

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
            configuraInicio();
        }

        private void configuraInicio()
        {
            LimpaTXT();
            CarregarGrid();
            ajustaColunasGrid();
            tabControl.SelectedTab = tabConsulta;
        }

        private void ajustaColunasGrid()
        {
            dbGrid.Columns[0].Visible = false;

            dbGrid.Columns[1].Width = 300;
            dbGrid.Columns[2].Width = 200;
            dbGrid.Columns[3].Width = 300;
            dbGrid.Columns[4].Width = 50;

            dbGrid.Columns[1].ReadOnly = true;
            dbGrid.Columns[2].ReadOnly = true;
            dbGrid.Columns[3].ReadOnly = true;
            dbGrid.Columns[4].ReadOnly = true;

            dbGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            fornecedor.Nome = txtNome.Text.Trim();
            fornecedor.CNPJ = txtCNPJ.Text.Trim();
            fornecedor.Endereco = txtEndereco.Text.Trim();
            fornecedor.isAtivo = chkAtivo.Checked == true ? true : false;

            if (iFornecedorID == 0)
                conn.Fornecedors.Add(fornecedor);

            conn.SaveChanges();

            configuraInicio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            configuraInicio();
        }

        private void dbGrid_DoubleClick(object sender, EventArgs e)
        {
            iFornecedorID = Convert.ToInt32(dbGrid.CurrentRow.Cells[0].Value);

            if (iFornecedorID != 0)
            {
                TestePraticoEntities conn = new TestePraticoEntities();
                Fornecedor fornecedor = conn.Fornecedors.Where(f => f.FornecedorID == iFornecedorID).Select(f => f).FirstOrDefault();

                if (fornecedor != null)
                {
                    LimpaTXT();
                    txtNome.Text = fornecedor.Nome;
                    txtCNPJ.Text = fornecedor.CNPJ;
                    txtEndereco.Text = fornecedor.Endereco;
                    chkAtivo.Checked = fornecedor.isAtivo;

                    tabControl.SelectedTab = tabCadastro;
                }
                else
                {
                    MessageBox.Show("Fornecedor não Localizado.");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            iFornecedorID = Convert.ToInt32(dbGrid.Rows[dbGrid.CurrentRow.Index].Cells["FornecedorID"].Value.ToString());

            TestePraticoEntities conn = new TestePraticoEntities();
            Fornecedor fornecedor = conn.Fornecedors.Where(f => f.FornecedorID == iFornecedorID).Select(f => f).FirstOrDefault();

            if (fornecedor != null)
            {
                conn.Fornecedors.Remove(fornecedor);
                conn.SaveChanges();

                MessageBox.Show("Fornecedor Excluido com Sucesso.");
            }

            configuraInicio();
        }
    }
}

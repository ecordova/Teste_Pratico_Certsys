using System;
using System.Data.Entity.Migrations;
using System.Transactions;
using System.Windows.Forms;
using testePratico.DAL;
using testePratico.Lib;
using testePratico.Model;

namespace testePratico.Cadastros
{
    public partial class Produtos : Form
    {
        private int iProdutoID = 0;

        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            configuraInicio();
        }

        private void configuraInicio()
        {
            LimpaTXT();
            CarregarGrid();
            tabControl.SelectedTab = tabConsulta;
        }

        private void CarregarGrid()
        {
            var lista = ProdutosDAL.listaProdutos();
            dbGrid.DataSource = lista;
            ajustaColunasGrid();
        }

        private void ajustaColunasGrid()
        {
            dbGrid.Columns[0].Visible = false;

            dbGrid.Columns[1].Width = 300;
            dbGrid.Columns[2].Width = 300;
            dbGrid.Columns[3].Width = 100;

            dbGrid.Columns[1].ReadOnly = true;
            dbGrid.Columns[2].ReadOnly = true;
            dbGrid.Columns[3].ReadOnly = true;
        }

        private void LimpaTXT()
        {
            txtNome.Clear();
            txtQuantidade.Value = 0;
            cbxFornecedor.SelectedIndex = -1;
        }

        private void Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtPesquisa.Text.Trim() != "")
                {
                    var lista = ProdutosDAL.pesquisaParcial(txtPesquisa.Text);

                    dbGrid.DataSource = lista;
                }
                else
                {
                    CarregarGrid();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            iProdutoID = Convert.ToInt32(dbGrid.Rows[dbGrid.CurrentRow.Index].Cells["ProdutoID"].Value.ToString());

            if (iProdutoID != 0)
            {
                bool bOK = ProdutosDAL.excluirProduto(iProdutoID);

                if (bOK)
                    MessageBox.Show("Produto Excluido com Sucesso.");
                else
                    MessageBox.Show(GlobalVars.Error_Messages);
            }

            configuraInicio();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            iProdutoID = 0;
            LimpaTXT();
            montaComboFornecedor();
            cbxFornecedor.SelectedIndex = -1;
            tabControl.SelectedTab = tabCadastro;
        }

        private void montaComboFornecedor()
        {
            var forn = FornecedoresDAL.buscaFornecedorCombo();
            cbxFornecedor.DataSource = forn;
            cbxFornecedor.ValueMember = "FornecedorID";
            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            configuraInicio();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "" || int.Parse(cbxFornecedor.SelectedValue.ToString()) <= 0 || txtQuantidade.Value <= 0)
            {
                MessageBox.Show("Os campos Nome, Fornecedor e Quantidade são Obrigatorios");
            }
            else
            {
                try
                {
                
                    TestePraticoEntities conn = new TestePraticoEntities();
                    Produto produto = new Produto();
                    Fornecedor fornecedor = new Fornecedor();

                    if (iProdutoID != 0)
                    {
                        produto = ProdutosDAL.buscaProdutoPorID(iProdutoID);
                    }

                    produto.Nome = txtNome.Text.Trim();
                    produto.FornecedorID = (int)cbxFornecedor.SelectedValue;
                    produto.Quantidade = (int)txtQuantidade.Value;

                    conn.Produtoes.AddOrUpdate(produto);
                    conn.SaveChanges();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: " + err.Message);
                }

                configuraInicio();
            }
        }

        private void dbGrid_DoubleClick(object sender, EventArgs e)
        {
            iProdutoID = Convert.ToInt32(dbGrid.CurrentRow.Cells[0].Value);

            if (iProdutoID != 0)
            {
                Produto prod = ProdutosDAL.buscaProdutoPorID(iProdutoID);

                if (prod != null)
                {
                    LimpaTXT();
                    montaComboFornecedor();

                    txtNome.Text = prod.Nome;
                    cbxFornecedor.SelectedValue = prod.FornecedorID;
                    txtQuantidade.Value = prod.Quantidade;

                    tabControl.SelectedTab = tabCadastro;
                }
                else
                {
                    MessageBox.Show("Produto não Localizado.");
                }
            }
        }
    }
}

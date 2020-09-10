namespace testePratico.Cadastros
{
    partial class Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(756, 375);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 35);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(7, 375);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConsulta);
            this.tabControl.Controls.Add(this.tabCadastro);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(867, 460);
            this.tabControl.TabIndex = 1;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.btnNovo);
            this.tabConsulta.Controls.Add(this.btnExcluir);
            this.tabConsulta.Controls.Add(this.dbGrid);
            this.tabConsulta.Controls.Add(this.txtPesquisa);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Location = new System.Drawing.Point(4, 34);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(859, 422);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dbGrid
            // 
            this.dbGrid.AllowUserToAddRows = false;
            this.dbGrid.AllowUserToDeleteRows = false;
            this.dbGrid.AllowUserToOrderColumns = true;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoID,
            this.NomeProduto,
            this.NomeFornecedor,
            this.Quantidade});
            this.dbGrid.Location = new System.Drawing.Point(7, 55);
            this.dbGrid.MultiSelect = false;
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.ReadOnly = true;
            this.dbGrid.RowHeadersVisible = false;
            this.dbGrid.RowHeadersWidth = 51;
            this.dbGrid.RowTemplate.Height = 24;
            this.dbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGrid.Size = new System.Drawing.Size(844, 314);
            this.dbGrid.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(133, 10);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(676, 30);
            this.txtPesquisa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.txtQuantidade);
            this.tabCadastro.Controls.Add(this.cbxFornecedor);
            this.tabCadastro.Controls.Add(this.btnSalvar);
            this.tabCadastro.Controls.Add(this.btnCancelar);
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 34);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(859, 422);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(238, 172);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 30);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(238, 112);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(428, 33);
            this.cbxFornecedor.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(709, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 35);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(33, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(238, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(428, 30);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // ProdutoID
            // 
            this.ProdutoID.DataPropertyName = "ProdutoID";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdutoID.DefaultCellStyle = dataGridViewCellStyle13;
            this.ProdutoID.HeaderText = "ProdutoID";
            this.ProdutoID.MinimumWidth = 6;
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.ReadOnly = true;
            this.ProdutoID.Width = 125;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProduto.DefaultCellStyle = dataGridViewCellStyle14;
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.MinimumWidth = 6;
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 125;
            // 
            // NomeFornecedor
            // 
            this.NomeFornecedor.DataPropertyName = "NomeFornecedor";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomeFornecedor.DefaultCellStyle = dataGridViewCellStyle15;
            this.NomeFornecedor.HeaderText = "Fornecedor";
            this.NomeFornecedor.MinimumWidth = 6;
            this.NomeFornecedor.Name = "NomeFornecedor";
            this.NomeFornecedor.ReadOnly = true;
            this.NomeFornecedor.Width = 125;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle16;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantidade.Width = 125;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 460);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Produtos_FormClosed);
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Produtos_KeyPress);
            this.tabControl.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}
namespace ControleDeEstoque
{
    partial class frmProduto
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
            this.tabControle = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabForm = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControle.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControle
            // 
            this.tabControle.Controls.Add(this.tabDados);
            this.tabControle.Controls.Add(this.tabForm);
            this.tabControle.Location = new System.Drawing.Point(12, 12);
            this.tabControle.Name = "tabControle";
            this.tabControle.SelectedIndex = 0;
            this.tabControle.Size = new System.Drawing.Size(788, 436);
            this.tabControle.TabIndex = 0;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.dataGridView1);
            this.tabDados.Controls.Add(this.btnExcluir);
            this.tabDados.Controls.Add(this.btnEditar);
            this.tabDados.Controls.Add(this.btnNovo);
            this.tabDados.Location = new System.Drawing.Point(4, 24);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(780, 408);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(778, 360);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(459, 372);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(339, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(223, 372);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.label5);
            this.tabForm.Controls.Add(this.label4);
            this.tabForm.Controls.Add(this.label3);
            this.tabForm.Controls.Add(this.label2);
            this.tabForm.Controls.Add(this.label1);
            this.tabForm.Controls.Add(this.cboUnidade);
            this.tabForm.Controls.Add(this.txtImposto);
            this.tabForm.Controls.Add(this.txtPreco);
            this.tabForm.Controls.Add(this.txtNomeProduto);
            this.tabForm.Controls.Add(this.txtIdProduto);
            this.tabForm.Controls.Add(this.btnSalvar);
            this.tabForm.Controls.Add(this.btnCancelar);
            this.tabForm.Location = new System.Drawing.Point(4, 24);
            this.tabForm.Name = "tabForm";
            this.tabForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabForm.Size = new System.Drawing.Size(780, 408);
            this.tabForm.TabIndex = 1;
            this.tabForm.Text = "Cadastro";
            this.tabForm.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aliquota de Imposto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID do Produto";
            // 
            // cboUnidade
            // 
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Items.AddRange(new object[] {
            "Arroba",
            "Caixa",
            "Fardo",
            "Kg",
            "Litro",
            "Lote",
            "Pacote",
            "Saca",
            "Tonelada",
            "Unidade"});
            this.cboUnidade.Location = new System.Drawing.Point(44, 190);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(152, 23);
            this.cboUnidade.TabIndex = 8;
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(253, 280);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(110, 23);
            this.txtImposto.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(44, 280);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 23);
            this.txtPreco.TabIndex = 6;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(44, 115);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(542, 23);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Location = new System.Drawing.Point(44, 45);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(152, 23);
            this.txtIdProduto.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(263, 372);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(696, 454);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabControle);
            this.Name = "frmProduto";
            this.Text = "Gestao de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.tabControle.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControle;
        private TabPage tabDados;
        private TabPage tabForm;
        private Button btnFechar;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboUnidade;
        private TextBox txtImposto;
        private TextBox txtPreco;
        private TextBox txtNomeProduto;
        private TextBox txtIdProduto;
    }
}
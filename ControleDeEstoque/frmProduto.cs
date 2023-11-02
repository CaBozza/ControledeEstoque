using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            botoes(2);
            tabControle.SelectedTab = tabForm;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Uteis.MensagemConfirmacao("Todos os campos devem ser preenchidos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botoes(1);
            tabControle.SelectedTab = tabDados;
        }
        // Metodo para controle dos botoes
        private void botoes(int tab)
        {

            if (tab == 1)
            {
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                btnFechar.Enabled = true;
            }
            if (tab == 2)
            {
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnFechar.Enabled = false;
            }

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            botoes(1);
        }
    }
}

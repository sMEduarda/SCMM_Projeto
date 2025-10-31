using System;
using System.Windows.Forms;

namespace SCMM_Projeto
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btn_os_Click(object sender, EventArgs e)
        {
            FrmSolicitacoes formSolicitacoes = new FrmSolicitacoes();

            // Mostra o formulário
            formSolicitacoes.Show();

            // CARREGA OS DADOS APÓS A TELA APARECER
            formSolicitacoes.BeginInvoke(new Action(() =>
            {
                formSolicitacoes.CarregarComboBoxes();
                formSolicitacoes.DefinirStatusPadrao();
            }));
        }
    }
}
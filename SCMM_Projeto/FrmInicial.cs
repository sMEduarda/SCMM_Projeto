using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCMM_Projeto
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        // --- Botão para abrir a tela de Ordens de Serviço ---
        private void btn_os_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário FrmSolicitacoes
            FrmSolicitacoes formSolicitacoes = new FrmSolicitacoes();

            // Mostra o formulário (como uma nova janela)
            formSolicitacoes.Show();

            // (Opcional) Esconde a tela atual, se quiser que só a outra fique aberta
            // this.Hide();
        }
    }
}

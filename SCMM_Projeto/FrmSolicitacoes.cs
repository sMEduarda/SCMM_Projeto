using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCMM_Projeto
{
    public partial class FrmSolicitacoes : Form
    {
        // Conexão com o banco de dados
        SqlConnection conexao = new SqlConnection("Data Source=SEU_SERVIDOR;Initial Catalog=SCMM_DB;Integrated Security=True");

        public FrmSolicitacoes()
        {
            InitializeComponent();
        }

        // --- BOTÃO SALVAR ---
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                string sql = "INSERT INTO OrdemServico " +
                             "(Solicitante, Telefone, Email, TipoEquipamento, Marca, Serie, DescricaoProblema, Prioridade, Status) " +
                             "VALUES (@Solicitante, @Telefone, @Email, @TipoEquipamento, @Marca, @Serie, @DescricaoProblema, @Prioridade, @Status)";

                SqlCommand cmd = new SqlCommand(sql, conexao);

                // Parâmetros com base nos TextBox e ComboBox da tela
                cmd.Parameters.AddWithValue("@Solicitante", txt_solicitante.Text);
                cmd.Parameters.AddWithValue("@Telefone", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@TipoEquipamento", cmb_tipo_equipamento.Text);
                cmd.Parameters.AddWithValue("@Marca", txt_marca.Text);
                cmd.Parameters.AddWithValue("@Serie", txt_serie.Text);
                cmd.Parameters.AddWithValue("@DescricaoProblema", txt_descricao_problema.Text);
                cmd.Parameters.AddWithValue("@Prioridade", cmb_prioridade.Text);
                cmd.Parameters.AddWithValue("@Status", "Aberta");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Solicitação registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar solicitação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        // --- BOTÃO LIMPAR ---
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // --- BOTÃO CANCELAR ---
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o formulário
        }

        // --- MÉTODO PARA LIMPAR CAMPOS ---
        private void LimparCampos()
        {
            txt_solicitante.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
            cmb_tipo_equipamento.SelectedIndex = -1;
            txt_marca.Clear();
            txt_serie.Clear();
            txt_descricao_problema.Clear();
            cmb_prioridade.SelectedIndex = -1;
        }

        // --- Remova métodos de evento não usados ---
        // Se existir algo como "label4_Click", delete tanto no código quanto no Designer.cs
    }
}

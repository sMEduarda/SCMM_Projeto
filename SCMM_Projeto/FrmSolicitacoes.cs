using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCMM_Projeto
{
    public partial class FrmSolicitacoes : Form
    {
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=SCMM_DB;Integrated Security=True;";
        private bool comboBoxesLoaded = false; // Evita carregar duas vezes

        public FrmSolicitacoes()
        {
            InitializeComponent();
        }

        // ==================== EVENTO SHOWN: DISPARA QUANDO A TELA ESTÁ VISÍVEL ====================
        private void FrmSolicitacoes_Shown(object sender, EventArgs e)
        {
            if (!comboBoxesLoaded)
            {
                comboBoxesLoaded = true;
                CarregarComboBoxes();
                DefinirStatusPadrao(); // Só seleciona "Aberto"
            }
        }

        // ==================== CARREGA COMBOBOXES (TIPO E PRIORIDADE EM BRANCO) ====================
        public void CarregarComboBoxes()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(CarregarComboBoxes));
                return;
            }

            CarregarComboBox(cmb_tipo_equipamento, "SELECT IdTipoEquipamento, Nome FROM TipoEquipamento", "Nome", "IdTipoEquipamento");
            CarregarComboBox(cmb_prioridade, "SELECT IdPrioridade, Nome FROM Prioridade", "Nome", "IdPrioridade");
            CarregarComboBox(cmb_status, "SELECT IdStatus, Nome FROM StatusOS", "Nome", "IdStatus");

            // DEIXA TIPO E PRIORIDADE EM BRANCO
            cmb_tipo_equipamento.SelectedIndex = -1;
            cmb_prioridade.SelectedIndex = -1;

            // Força atualização visual
            cmb_tipo_equipamento.Refresh();
            cmb_prioridade.Refresh();
            cmb_status.Refresh();
        }

        private void CarregarComboBox(ComboBox combo, string query, string displayMember, string valueMember)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        combo.Items.Clear();
                        combo.Items.Add("(Nenhum item)");
                        return;
                    }

                    combo.DataSource = null;
                    combo.Items.Clear();

                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;

                    combo.Update();
                    combo.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar {combo.Name}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== STATUS PADRÃO: SÓ "ABERTO" SELECIONADO ====================
        public void DefinirStatusPadrao()
        {
            if (cmb_status.Items.Count > 0)
            {
                foreach (DataRowView item in cmb_status.Items)
                {
                    if (item["Nome"].ToString().Equals("Aberto", StringComparison.OrdinalIgnoreCase))
                    {
                        cmb_status.SelectedValue = item["IdStatus"];
                        break;
                    }
                }
            }
        }

        // ==================== BOTÃO SALVAR ====================
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                        INSERT INTO OrdemServico 
                        (Solicitante, Responsavel, Telefone, Email, IdTipoEquipamento, Marca, Serie, DescricaoProblema, IdPrioridade, IdStatus)
                        VALUES 
                        (@Solicitante, @Responsavel, @Telefone, @Email, @IdTipoEquipamento, @Marca, @Serie, @DescricaoProblema, @IdPrioridade, @IdStatus)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Solicitante", txt_solicitante.Text.Trim());
                    cmd.Parameters.AddWithValue("@Responsavel", string.IsNullOrWhiteSpace(txt_responsavel.Text) ? (object)DBNull.Value : txt_responsavel.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefone", string.IsNullOrWhiteSpace(txt_telefone.Text) ? (object)DBNull.Value : txt_telefone.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txt_email.Text) ? (object)DBNull.Value : txt_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdTipoEquipamento", cmb_tipo_equipamento.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Marca", string.IsNullOrWhiteSpace(txt_marca.Text) ? (object)DBNull.Value : txt_marca.Text.Trim());
                    cmd.Parameters.AddWithValue("@Serie", string.IsNullOrWhiteSpace(txt_serie.Text) ? (object)DBNull.Value : txt_serie.Text.Trim());
                    cmd.Parameters.AddWithValue("@DescricaoProblema", txt_descricao_problema.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdPrioridade", cmb_prioridade.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdStatus", cmb_status.SelectedValue ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Solicitação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== VALIDAÇÃO ====================
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_solicitante.Text))
            {
                MessageBox.Show("Solicitante é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_solicitante.Focus();
                return false;
            }
            if (cmb_tipo_equipamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Tipo de Equipamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_tipo_equipamento.Focus();
                return false;
            }
            if (cmb_prioridade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a Prioridade.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_prioridade.Focus();
                return false;
            }
            if (cmb_status.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Status.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_status.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_descricao_problema.Text))
            {
                MessageBox.Show("Descrição é obrigatória.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_descricao_problema.Focus();
                return false;
            }
            return true;
        }

        // ==================== LIMPAR E CANCELAR ====================
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void LimparCampos()
        {
            txt_solicitante.Clear();
            txt_responsavel.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
            txt_marca.Clear();
            txt_serie.Clear();
            txt_descricao_problema.Clear();

            cmb_tipo_equipamento.SelectedIndex = -1;
            cmb_prioridade.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;

            DefinirStatusPadrao();
            txt_solicitante.Focus();
        }
    }
}
namespace SCMM_Projeto
{
    partial class FrmSolicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitacoes));
            txt_solicitante = new TextBox();
            lbl_titulo_principal = new Label();
            panel1 = new Panel();
            txt_responsavel = new TextBox();
            lbl_serie = new Label();
            txt_serie = new TextBox();
            cmb_status = new ComboBox();
            lbl_status = new Label();
            cmb_prioridade = new ComboBox();
            lbl_prioridade = new Label();
            lbl_descricao_problema = new Label();
            txt_descricao_problema = new TextBox();
            lbl_data_abertura = new Label();
            txt_data_abertura = new TextBox();
            lbl_Detalhes_Solicitacao = new Label();
            lbl_marca = new Label();
            txt_marca = new TextBox();
            cmb_tipo_equipamento = new ComboBox();
            lbl_tipo_equipamneto = new Label();
            lbl_dados_equipamento_titulo = new Label();
            lbl_telefone = new Label();
            txt_telefone = new TextBox();
            lbl_Email = new Label();
            txt_email = new TextBox();
            lbl_responsavel = new Label();
            lbl_dados_solicitante_titulo = new Label();
            lbl_Solicitante = new Label();
            btn_salvar = new Button();
            btn_limpar = new Button();
            btn_cancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_solicitante
            // 
            txt_solicitante.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_solicitante.Location = new Point(279, 55);
            txt_solicitante.Name = "txt_solicitante";
            txt_solicitante.Size = new Size(275, 30);
            txt_solicitante.TabIndex = 0;
            // 
            // lbl_titulo_principal
            // 
            lbl_titulo_principal.AutoSize = true;
            lbl_titulo_principal.BackColor = Color.Transparent;
            lbl_titulo_principal.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo_principal.ForeColor = Color.White;
            lbl_titulo_principal.Location = new Point(312, 22);
            lbl_titulo_principal.Name = "lbl_titulo_principal";
            lbl_titulo_principal.Size = new Size(732, 54);
            lbl_titulo_principal.TabIndex = 1;
            lbl_titulo_principal.Text = "Criação da Ordens de Serviço";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txt_responsavel);
            panel1.Controls.Add(lbl_serie);
            panel1.Controls.Add(txt_serie);
            panel1.Controls.Add(cmb_status);
            panel1.Controls.Add(lbl_status);
            panel1.Controls.Add(cmb_prioridade);
            panel1.Controls.Add(lbl_prioridade);
            panel1.Controls.Add(lbl_descricao_problema);
            panel1.Controls.Add(txt_descricao_problema);
            panel1.Controls.Add(lbl_data_abertura);
            panel1.Controls.Add(txt_data_abertura);
            panel1.Controls.Add(lbl_Detalhes_Solicitacao);
            panel1.Controls.Add(lbl_marca);
            panel1.Controls.Add(txt_marca);
            panel1.Controls.Add(cmb_tipo_equipamento);
            panel1.Controls.Add(lbl_tipo_equipamneto);
            panel1.Controls.Add(lbl_dados_equipamento_titulo);
            panel1.Controls.Add(lbl_telefone);
            panel1.Controls.Add(txt_telefone);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(lbl_responsavel);
            panel1.Controls.Add(lbl_dados_solicitante_titulo);
            panel1.Controls.Add(lbl_Solicitante);
            panel1.Controls.Add(txt_solicitante);
            panel1.Location = new Point(93, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 607);
            panel1.TabIndex = 2;
            // 
            // txt_responsavel
            // 
            txt_responsavel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_responsavel.Location = new Point(747, 440);
            txt_responsavel.Name = "txt_responsavel";
            txt_responsavel.Size = new Size(275, 30);
            txt_responsavel.TabIndex = 28;
            // 
            // lbl_serie
            // 
            lbl_serie.AutoSize = true;
            lbl_serie.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_serie.ForeColor = Color.White;
            lbl_serie.Location = new Point(131, 335);
            lbl_serie.Name = "lbl_serie";
            lbl_serie.Size = new Size(142, 25);
            lbl_serie.TabIndex = 27;
            lbl_serie.Text = "Num. de Série:";
            // 
            // txt_serie
            // 
            txt_serie.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_serie.Location = new Point(279, 332);
            txt_serie.Name = "txt_serie";
            txt_serie.Size = new Size(275, 30);
            txt_serie.TabIndex = 26;
            // 
            // cmb_status
            // 
            cmb_status.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_status.FormattingEnabled = true;
            cmb_status.Location = new Point(747, 482);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(174, 32);
            cmb_status.TabIndex = 25;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_status.ForeColor = Color.White;
            lbl_status.Location = new Point(670, 486);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(74, 25);
            lbl_status.TabIndex = 24;
            lbl_status.Text = "Status:";
            // 
            // cmb_prioridade
            // 
            cmb_prioridade.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_prioridade.FormattingEnabled = true;
            cmb_prioridade.Location = new Point(279, 521);
            cmb_prioridade.Name = "cmb_prioridade";
            cmb_prioridade.Size = new Size(174, 32);
            cmb_prioridade.TabIndex = 23;
            // 
            // lbl_prioridade
            // 
            lbl_prioridade.AutoSize = true;
            lbl_prioridade.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_prioridade.ForeColor = Color.White;
            lbl_prioridade.Location = new Point(167, 524);
            lbl_prioridade.Name = "lbl_prioridade";
            lbl_prioridade.Size = new Size(106, 25);
            lbl_prioridade.TabIndex = 22;
            lbl_prioridade.Text = "Prioridade:";
            // 
            // lbl_descricao_problema
            // 
            lbl_descricao_problema.AutoSize = true;
            lbl_descricao_problema.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_descricao_problema.ForeColor = Color.White;
            lbl_descricao_problema.Location = new Point(55, 484);
            lbl_descricao_problema.Name = "lbl_descricao_problema";
            lbl_descricao_problema.Size = new Size(220, 25);
            lbl_descricao_problema.TabIndex = 21;
            lbl_descricao_problema.Text = "Descrição do Problema:";
            // 
            // txt_descricao_problema
            // 
            txt_descricao_problema.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_descricao_problema.Location = new Point(279, 482);
            txt_descricao_problema.Name = "txt_descricao_problema";
            txt_descricao_problema.Size = new Size(275, 30);
            txt_descricao_problema.TabIndex = 20;
            // 
            // lbl_data_abertura
            // 
            lbl_data_abertura.AutoSize = true;
            lbl_data_abertura.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_data_abertura.ForeColor = Color.White;
            lbl_data_abertura.Location = new Point(107, 445);
            lbl_data_abertura.Name = "lbl_data_abertura";
            lbl_data_abertura.Size = new Size(166, 25);
            lbl_data_abertura.TabIndex = 19;
            lbl_data_abertura.Text = "Data de Abertura:";
            // 
            // txt_data_abertura
            // 
            txt_data_abertura.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_data_abertura.Location = new Point(279, 440);
            txt_data_abertura.Name = "txt_data_abertura";
            txt_data_abertura.Size = new Size(275, 30);
            txt_data_abertura.TabIndex = 18;
            // 
            // lbl_Detalhes_Solicitacao
            // 
            lbl_Detalhes_Solicitacao.AutoSize = true;
            lbl_Detalhes_Solicitacao.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Detalhes_Solicitacao.ForeColor = Color.Red;
            lbl_Detalhes_Solicitacao.Location = new Point(26, 398);
            lbl_Detalhes_Solicitacao.Name = "lbl_Detalhes_Solicitacao";
            lbl_Detalhes_Solicitacao.Size = new Size(195, 24);
            lbl_Detalhes_Solicitacao.TabIndex = 17;
            lbl_Detalhes_Solicitacao.Text = "Detalhes da Solicitação:";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_marca.ForeColor = Color.White;
            lbl_marca.Location = new Point(200, 295);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(73, 25);
            lbl_marca.TabIndex = 14;
            lbl_marca.Text = "Marca:";
            // 
            // txt_marca
            // 
            txt_marca.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_marca.Location = new Point(279, 290);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(275, 30);
            txt_marca.TabIndex = 13;
            // 
            // cmb_tipo_equipamento
            // 
            cmb_tipo_equipamento.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_tipo_equipamento.FormattingEnabled = true;
            cmb_tipo_equipamento.Location = new Point(279, 244);
            cmb_tipo_equipamento.Name = "cmb_tipo_equipamento";
            cmb_tipo_equipamento.Size = new Size(275, 32);
            cmb_tipo_equipamento.TabIndex = 12;
            // 
            // lbl_tipo_equipamneto
            // 
            lbl_tipo_equipamneto.AutoSize = true;
            lbl_tipo_equipamneto.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_tipo_equipamneto.ForeColor = Color.White;
            lbl_tipo_equipamneto.Location = new Point(69, 246);
            lbl_tipo_equipamneto.Name = "lbl_tipo_equipamneto";
            lbl_tipo_equipamneto.Size = new Size(204, 25);
            lbl_tipo_equipamneto.TabIndex = 11;
            lbl_tipo_equipamneto.Text = "Tipo de Equipamento:";
            // 
            // lbl_dados_equipamento_titulo
            // 
            lbl_dados_equipamento_titulo.AutoSize = true;
            lbl_dados_equipamento_titulo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dados_equipamento_titulo.ForeColor = Color.Red;
            lbl_dados_equipamento_titulo.Location = new Point(26, 189);
            lbl_dados_equipamento_titulo.Name = "lbl_dados_equipamento_titulo";
            lbl_dados_equipamento_titulo.Size = new Size(192, 24);
            lbl_dados_equipamento_titulo.TabIndex = 10;
            lbl_dados_equipamento_titulo.Text = "Dados do Equipamento";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_telefone.ForeColor = Color.White;
            lbl_telefone.Location = new Point(180, 103);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(95, 25);
            lbl_telefone.TabIndex = 9;
            lbl_telefone.Text = "Telefone:";
            // 
            // txt_telefone
            // 
            txt_telefone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefone.Location = new Point(279, 101);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(275, 30);
            txt_telefone.TabIndex = 8;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(200, 148);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(74, 25);
            lbl_Email.TabIndex = 7;
            lbl_Email.Text = "E-Mail:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(279, 146);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(275, 30);
            txt_email.TabIndex = 6;
            // 
            // lbl_responsavel
            // 
            lbl_responsavel.AutoSize = true;
            lbl_responsavel.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_responsavel.ForeColor = Color.White;
            lbl_responsavel.Location = new Point(614, 445);
            lbl_responsavel.Name = "lbl_responsavel";
            lbl_responsavel.Size = new Size(131, 25);
            lbl_responsavel.TabIndex = 4;
            lbl_responsavel.Text = "Responsável:";
            // 
            // lbl_dados_solicitante_titulo
            // 
            lbl_dados_solicitante_titulo.AutoSize = true;
            lbl_dados_solicitante_titulo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dados_solicitante_titulo.ForeColor = Color.Red;
            lbl_dados_solicitante_titulo.Location = new Point(26, 18);
            lbl_dados_solicitante_titulo.Name = "lbl_dados_solicitante_titulo";
            lbl_dados_solicitante_titulo.Size = new Size(170, 24);
            lbl_dados_solicitante_titulo.TabIndex = 2;
            lbl_dados_solicitante_titulo.Text = "Dados do Solicitante";
            // 
            // lbl_Solicitante
            // 
            lbl_Solicitante.AutoSize = true;
            lbl_Solicitante.Font = new Font("Microsoft Sans Serif", 12F);
            lbl_Solicitante.ForeColor = Color.White;
            lbl_Solicitante.Location = new Point(167, 57);
            lbl_Solicitante.Name = "lbl_Solicitante";
            lbl_Solicitante.Size = new Size(108, 25);
            lbl_Solicitante.TabIndex = 1;
            lbl_Solicitante.Text = "Solicitante:";
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.LimeGreen;
            btn_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salvar.ForeColor = Color.White;
            btn_salvar.Location = new Point(412, 711);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(113, 38);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.Gold;
            btn_limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpar.ForeColor = Color.White;
            btn_limpar.Location = new Point(614, 711);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(113, 38);
            btn_limpar.TabIndex = 4;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(805, 711);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(113, 38);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FrmSolicitacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1313, 784);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_limpar);
            Controls.Add(btn_salvar);
            Controls.Add(panel1);
            Controls.Add(lbl_titulo_principal);
            DoubleBuffered = true;
            Name = "FrmSolicitacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitações";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_solicitante;
        private Label lbl_titulo_principal;
        private Panel panel1;
        private Label lbl_Solicitante;
        private Label lbl_responsavel;
        private Label lbl_dados_solicitante_titulo;
        private Label lbl_telefone;
        private TextBox txt_telefone;
        private Label lbl_Email;
        private TextBox txt_email;
        private Label lbl_marca;
        private TextBox txt_marca;
        private ComboBox cmb_tipo_equipamento;
        private Label lbl_tipo_equipamneto;
        private Label lbl_dados_equipamento_titulo;
        private ComboBox cmb_prioridade;
        private Label lbl_prioridade;
        private Label lbl_descricao_problema;
        private TextBox txt_descricao_problema;
        private Label lbl_data_abertura;
        private TextBox txt_data_abertura;
        private Label lbl_Detalhes_Solicitacao;
        private ComboBox cmb_status;
        private Label lbl_status;
        private Button btn_salvar;
        private Button btn_limpar;
        private Button btn_cancelar;
        private Label lbl_serie;
        private TextBox txt_serie;
        private TextBox txt_responsavel;
    }
}
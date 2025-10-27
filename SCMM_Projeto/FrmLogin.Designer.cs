using Microsoft.Data.SqlClient;

namespace SCMM_Projeto
{
    partial class FrmLogin
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            panelLogin = new Panel();
            lblSenha = new Label();
            lblUsuario = new Label();
            btnEntrar = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(38, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Digite o Usuário";
            txtUsuario.Size = new Size(280, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(40, 136);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a Senha";
            txtSenha.Size = new Size(280, 27);
            txtSenha.TabIndex = 1;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Location = new Point(437, 393);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(355, 256);
            panelLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(140, 106);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(69, 25);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(135, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(82, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(192, 255, 192);
            btnEntrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.DarkGreen;
            btnEntrar.Location = new Point(121, 198);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(115, 35);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo_login1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1240, 711);
            Controls.Add(panelLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtSenha.Text.Trim();
            string senha = txtUsuario.Text; // ideal: usar hash no banco

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha usuário e senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // String de conexão: ajuste conforme seu servidor e banco
            string connStr = @"Data Source=SEU_SERVIDOR;Initial Catalog=SCMM;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string sql = "SELECT COUNT(1) FROM Usuario WHERE Login=@usuario AND Senha=@senha";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        con.Open();
                        int resultado = (int)cmd.ExecuteScalar();
                        if (resultado > 0)
                        {
                            // Login OK, abre tela inicial
                            FrmInicial frm = new FrmInicial();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco: " + ex.Message);
                    }
                }
            }
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Panel panelLogin;
        private Button btnEntrar;
        private Label lblSenha;
        private Label lblUsuario;
    }

}
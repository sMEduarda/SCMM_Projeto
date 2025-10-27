using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCMM_Projeto
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InicializarComponentesCustomizados()
        {
            // Criar panelLogin caso não exista
            panelLogin = new Panel
            {
                Size = new Size(300, 200), // Defina o tamanho desejado
            };
            this.Controls.Add(panelLogin);

            // Criar TextBoxes e Button
            txtUsuario = new TextBox { PlaceholderText = "Usuário", Location = new Point(50, 50), Width = 200 };
            txtSenha = new TextBox { PlaceholderText = "Senha", Location = new Point(50, 90), Width = 200, UseSystemPasswordChar = true };
            btnEntrar = new Button { Text = "Entrar", Location = new Point(100, 140), Width = 100 };

            btnEntrar.Click += btnEntrar_Click_1;

            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(btnEntrar);

        }
        private void ConfigurarPanelLogin()
        {
            if (panelLogin != null)
            {
                // Apenas configurar aparência, sem alterar a posição
                panelLogin.BackColor = Color.FromArgb(180, 255, 255, 255); // branco translúcido
                panelLogin.BorderStyle = BorderStyle.None;
                // Não mexer na Location nem no Anchor
            }
        }
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            // Corrigido: txtUsuario -> usuario, txtSenha -> senha
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha usuário e senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aqui você pode colocar a lógica de login com o banco de dados
            MessageBox.Show($"Usuário: {usuario}\nSenha: {senha}", "Teste de Login");
        }

    }
}

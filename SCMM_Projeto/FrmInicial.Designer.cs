namespace SCMM_Projeto
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            btn_os = new Button();
            btn_conslutarOS = new Button();
            btn_ConsultarMateriais = new Button();
            btn_cadastrarMateriais = new Button();
            SuspendLayout();
            // 
            // btn_os
            // 
            btn_os.BackColor = Color.RoyalBlue;
            btn_os.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_os.ForeColor = Color.White;
            btn_os.Location = new Point(300, 266);
            btn_os.Name = "btn_os";
            btn_os.Size = new Size(305, 66);
            btn_os.TabIndex = 0;
            btn_os.Text = "Criar Nova Ordem De Serviço";
            btn_os.UseVisualStyleBackColor = false;
            btn_os.Click += btn_os_Click;
            // 
            // btn_conslutarOS
            // 
            btn_conslutarOS.BackColor = Color.RoyalBlue;
            btn_conslutarOS.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_conslutarOS.ForeColor = Color.White;
            btn_conslutarOS.Location = new Point(696, 266);
            btn_conslutarOS.Name = "btn_conslutarOS";
            btn_conslutarOS.Size = new Size(305, 66);
            btn_conslutarOS.TabIndex = 1;
            btn_conslutarOS.Text = "Consultar Ordens De Serviço";
            btn_conslutarOS.UseVisualStyleBackColor = false;
            btn_conslutarOS.Click += button1_Click;
            // 
            // btn_ConsultarMateriais
            // 
            btn_ConsultarMateriais.BackColor = Color.MediumVioletRed;
            btn_ConsultarMateriais.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ConsultarMateriais.ForeColor = Color.White;
            btn_ConsultarMateriais.Location = new Point(696, 408);
            btn_ConsultarMateriais.Name = "btn_ConsultarMateriais";
            btn_ConsultarMateriais.Size = new Size(305, 66);
            btn_ConsultarMateriais.TabIndex = 2;
            btn_ConsultarMateriais.Text = "Consultar Materiais";
            btn_ConsultarMateriais.UseVisualStyleBackColor = false;
            // 
            // btn_cadastrarMateriais
            // 
            btn_cadastrarMateriais.BackColor = Color.MediumVioletRed;
            btn_cadastrarMateriais.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrarMateriais.ForeColor = Color.White;
            btn_cadastrarMateriais.Location = new Point(300, 408);
            btn_cadastrarMateriais.Name = "btn_cadastrarMateriais";
            btn_cadastrarMateriais.Size = new Size(305, 66);
            btn_cadastrarMateriais.TabIndex = 3;
            btn_cadastrarMateriais.Text = "Cadastrar Materiais";
            btn_cadastrarMateriais.UseVisualStyleBackColor = false;
            btn_cadastrarMateriais.Click += btn_cadastrarMateriais_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1325, 761);
            Controls.Add(btn_cadastrarMateriais);
            Controls.Add(btn_ConsultarMateriais);
            Controls.Add(btn_conslutarOS);
            Controls.Add(btn_os);
            Name = "FrmInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_os;
        private Button btn_conslutarOS;
        private Button btn_ConsultarMateriais;
        private Button btn_cadastrarMateriais;
    }
}
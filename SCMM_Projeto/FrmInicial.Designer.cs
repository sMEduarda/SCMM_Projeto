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
            SuspendLayout();
            // 
            // btn_os
            // 
            btn_os.Location = new Point(401, 370);
            btn_os.Name = "btn_os";
            btn_os.Size = new Size(94, 29);
            btn_os.TabIndex = 0;
            btn_os.Text = "Ordens de Serviço";
            btn_os.UseVisualStyleBackColor = true;
            btn_os.Click += btn_os_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1325, 761);
            Controls.Add(btn_os);
            Name = "FrmInicial";
            Text = "Tela Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_os;
    }
}
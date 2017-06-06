namespace PI
{
    partial class Cadastro
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
            this.panelPerfil1 = new PI.PanelPerfil();
            this.SuspendLayout();
            // 
            // panelPerfil1
            // 
            this.panelPerfil1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPerfil1.Location = new System.Drawing.Point(-2, 61);
            this.panelPerfil1.Name = "panelPerfil1";
            this.panelPerfil1.Size = new System.Drawing.Size(479, 345);
            this.panelPerfil1.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 409);
            this.Controls.Add(this.panelPerfil1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private PanelPerfil panelPerfil1;
    }
}
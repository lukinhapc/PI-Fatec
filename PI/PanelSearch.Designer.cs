namespace PI
{
    partial class PanelSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPesquisa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Depth = 0;
            this.txtPesquisa.Hint = "Pesquisar";
            this.txtPesquisa.Location = new System.Drawing.Point(18, 20);
            this.txtPesquisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(426, 23);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.UseSystemPasswordChar = false;
            // 
            // PanelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPesquisa);
            this.Name = "PanelSearch";
            this.Size = new System.Drawing.Size(470, 405);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisa;
    }
}

namespace PI
{
    partial class FormInicial
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
            this.pnlLeft = new MaterialSkin.Controls.MaterialDivider();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.btnConexoes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnChats = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSair = new MaterialSkin.Controls.MaterialRaisedButton();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.panelChat1 = new PI.PanelChat();
            this.panelPerfil = new PI.PanelPerfil();
            this.panelSearch1 = new PI.PanelSearch();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLeft.Depth = 0;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(192, 498);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(52, 209);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(81, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Aqui";
            // 
            // btnConexoes
            // 
            this.btnConexoes.Depth = 0;
            this.btnConexoes.Location = new System.Drawing.Point(0, 250);
            this.btnConexoes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConexoes.Name = "btnConexoes";
            this.btnConexoes.Primary = true;
            this.btnConexoes.Size = new System.Drawing.Size(192, 58);
            this.btnConexoes.TabIndex = 4;
            this.btnConexoes.Text = "Conexões";
            this.btnConexoes.UseVisualStyleBackColor = true;
            this.btnConexoes.Click += new System.EventHandler(this.conexao);
            // 
            // btnChats
            // 
            this.btnChats.Depth = 0;
            this.btnChats.Location = new System.Drawing.Point(0, 320);
            this.btnChats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChats.Name = "btnChats";
            this.btnChats.Primary = true;
            this.btnChats.Size = new System.Drawing.Size(192, 58);
            this.btnChats.TabIndex = 5;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = true;
            this.btnChats.Click += new System.EventHandler(this.chats);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Depth = 0;
            this.btnSair.Location = new System.Drawing.Point(0, 440);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.Primary = true;
            this.btnSair.Size = new System.Drawing.Size(192, 58);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.close);
            // 
            // imgPerfil
            // 
            this.imgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.imgPerfil.Image = global::PI.Properties.Resources.perfil;
            this.imgPerfil.Location = new System.Drawing.Point(21, 71);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(150, 130);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 2;
            this.imgPerfil.TabStop = false;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.Controls.Add(this.panelPerfil);
            this.pnlCenter.Controls.Add(this.panelSearch1);
            this.pnlCenter.Location = new System.Drawing.Point(193, 63);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(554, 434);
            this.pnlCenter.TabIndex = 0;
            // 
            // panelChat1
            // 
            this.panelChat1.Location = new System.Drawing.Point(194, 63);
            this.panelChat1.Name = "panelChat1";
            this.panelChat1.Size = new System.Drawing.Size(553, 435);
            this.panelChat1.TabIndex = 7;
            // 
            // panelPerfil
            // 
            this.panelPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(554, 435);
            this.panelPerfil.TabIndex = 2;
            this.panelPerfil.Visible = false;
            // 
            // panelSearch1
            // 
            this.panelSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch1.Location = new System.Drawing.Point(0, 0);
            this.panelSearch1.Name = "panelSearch1";
            this.panelSearch1.Size = new System.Drawing.Size(554, 435);
            this.panelSearch1.TabIndex = 0;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Controls.Add(this.panelChat1);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnChats);
            this.Controls.Add(this.btnConexoes);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.pnlLeft);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormInicial";
            this.Text = "Consulte-me";
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider pnlLeft;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private MaterialSkin.Controls.MaterialRaisedButton btnConexoes;
        private MaterialSkin.Controls.MaterialRaisedButton btnChats;
        private MaterialSkin.Controls.MaterialRaisedButton btnSair;
        private System.Windows.Forms.PictureBox imgPerfil;
        private PanelPerfil panelPerfil;
        private PanelSearch panelSearch1;
        private System.Windows.Forms.Panel pnlCenter;
        private PanelChat panelChat1;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin.Controls;

namespace PI
{
    class PanelConexao : Panel
    {
        private PictureBox pictureBox1;
        private MaterialLabel lblNome;
        private TextBox textBox1;
        public PanelConexao()
        {

            pictureBox1 = new PictureBox();
            lblNome = new MaterialLabel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            pictureBox1.Location = new Point(0, 63);
            pictureBox1.Size = new Size(299, 105);
            pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Depth = 0;
            lblNome.Font = new Font("Roboto", 11F);
            lblNome.ForeColor = Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lblNome.Location = new Point(12, 171);
            lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            lblNome.Size = new Size(54, 19);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            textBox1.Location = new Point(2, 193);
            textBox1.Multiline = true;
            textBox1.Size = new Size(295, 104);
            textBox1.TabIndex = 3;
            // 
            // Form4
            // 
            this.Size = new Size(6, 13);
            this.Controls.Add(textBox1);
            this.Controls.Add(lblNome);
            this.Controls.Add(pictureBox1);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

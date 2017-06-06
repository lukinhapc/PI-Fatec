using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class PanelPerfil : UserControl
    {
        public PanelPerfil()
        {
            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, imgPerfil2.Width - 3, imgPerfil2.Height - 3);
            Region rg = new Region(gp);
            imgPerfil2.Region = rg;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}

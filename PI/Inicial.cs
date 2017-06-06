using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class FormInicial : MaterialForm
    {
        public FormInicial()
        {

            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, imgPerfil.Width - 3, imgPerfil.Height - 3);
            Region rg = new Region(gp);
            imgPerfil.Region = rg;

            panelPerfil.Visible = false;
            panelChat1.Visible = false;
        }

        private void conexao(object sender, EventArgs e)
        {
            panelPerfil.Visible = true;
            panelChat1.Visible = false;
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chats(object sender, EventArgs e)
        {
            panelChat1.Visible = true;
            panelPerfil.Visible = false;
        }
    }
}

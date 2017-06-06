using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Cadastro : MaterialForm
    {
        public Cadastro()
        {
            InitializeComponent();
            panelPerfil1.VisibleChanged += new EventHandler(this.UserControl2VisibleChanged);
        }

        private void UserControl2VisibleChanged(object sender, EventArgs e)
        {
            if (!panelPerfil1.Visible)
            {
                this.Close();
            }
        }
    }
}

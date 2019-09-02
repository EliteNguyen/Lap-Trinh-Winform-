using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWINFORM
{
    public partial class frnMDI : Form
    {
        public frnMDI()
        {
            InitializeComponent();
        }

        private void frnMDI_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }
    }
}

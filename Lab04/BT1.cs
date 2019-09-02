using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

       long sum = 0;
        private long TinhTien()
        {
            sum = 0;
            if (chkClean.Checked)
                sum += 100000;
            if (chkWhitening.Checked)
                sum += 1200000;
            if (chkXRay.Checked)
                sum += 200000;

            sum += (long)numFilling.Value * 80000;

            txtTotal.Text = sum.ToString();

            return sum;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.TinhTien();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        int USCLN(int a, int b)
        {


            while(a!=b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            int a = Math.Abs(int.Parse(txtNumA.Text));
            int b = Math.Abs(int.Parse(txtNumB.Text));

            if (rbtUCLN.Checked)
            {
                txtResult.Text = USCLN(a,b).ToString();
            }
            if(rbtBCNN.Checked)
            {
                txtResult.Text = BSCNN(a, b).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

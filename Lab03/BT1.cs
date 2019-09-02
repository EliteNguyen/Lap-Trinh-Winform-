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
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNumN.Text);
            float m = float.Parse(txtNumM.Text);
            txtResult.Text = (n + m).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNumN.Text);
            float m = float.Parse(txtNumM.Text);
            txtResult.Text = (n - m).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNumN.Text);
            float m = float.Parse(txtNumM.Text);
            txtResult.Text = (n * m).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNumN.Text);
            float m = float.Parse(txtNumM.Text);
            txtResult.Text = (n / m).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumM.Text = "";
            txtNumN.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

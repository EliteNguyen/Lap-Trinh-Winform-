using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class BT3 : Form
    {
        public BT3()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            txtSecurityCode.Text += x.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int pass;

            if (!int.TryParse(txtSecurityCode.Text, out pass))
            {
                MessageBox.Show("Không đúng định dạng dữ liệu, vui lòng Clear và nhập lại", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pass < 1000 || pass > 9999)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Restricted Access!");
                txtSecurityCode.Clear();
            }

            if (pass == 1645 || pass == 1689)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Technicians");
                txtSecurityCode.Clear();
            }

            if (pass == 8345)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Custodians");
                txtSecurityCode.Clear();
            }

            if (pass == 9998 || pass == 1006 || pass == 1007 || pass == 1008)
            {
                listLog.Items.Add(DateTime.Now + "\t" + "Scientist");
                txtSecurityCode.Clear();
            }



        }

        private void BT3_Load(object sender, EventArgs e)
        {

        }
    }
}

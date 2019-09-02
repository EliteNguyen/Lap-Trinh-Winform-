using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
 
    public partial class BT2 : Form
    {
        long sum = 0;

        public BT2()
        {
            InitializeComponent();
        }

        private long TinhTien()
        {
            sum = 0;
            if (checkCaoVoi.Checked)
                sum += 100000;
            if (checkTayTrang.Checked)
                sum += 1200000;
            if (checkChup.Checked)
                sum += 200000;

            sum += (long)txtTram.Value * 80000;

            txtTong.Text = sum.ToString();

            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TinhTien();
            listKhach.Items.Add(txtName.Text+ "\t" + TinhTien());
            txtName.Text = "";
            checkChup.Checked = false;
            checkCaoVoi.Checked = false;
            checkTayTrang.Checked = false;
            txtTong.Text = "";

        }
        private string ChonFile(bool open = true)
        {
            FileDialog theDialog;
            if (open) theDialog = new OpenFileDialog();
            else theDialog = new SaveFileDialog();
            theDialog.Title = "Chọn file";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Application.ExecutablePath;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                return theDialog.FileName.ToString();
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = ChonFile();
            if (fileName == null) return;
            FileStream myStream = new FileStream(fileName, FileMode.Open);
            myStream.Close();
            MessageBox.Show("Load dữ liệu hoàn tất");
        }
    }
}

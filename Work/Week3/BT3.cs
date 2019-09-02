using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listDS.Items.Add(txtName.Text);
            lvi.SubItems.Add(txtDate.Text);
            lvi.SubItems.Add(txtPhone.Text);
            lvi.SubItems.Add(txtAddress.Text);
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listDS.SelectedItems.Count;

            if(index > 0)
            {
                txtName.Text = listDS.SelectedItems[0].SubItems[0].Text;
                txtDate.Text = listDS.SelectedItems[0].SubItems[1].Text;
                txtPhone.Text = listDS.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = listDS.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                listDS.Items.Remove(listDS.SelectedItems[0]);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                listDS.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listDS.SelectedItems[0].SubItems[1].Text = txtDate.Text;
                listDS.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
                listDS.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

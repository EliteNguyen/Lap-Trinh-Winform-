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
    public partial class frmLogin : Form
    {
        LoginObject lgo;
        LoginLogic lglg = new LoginLogic();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {

            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Du lieu khong duoc bo trong ");
                return;

            }
            lgo = new LoginObject(txtUser.Text, txtPass.Text);
            DataTable dt = new DataTable();
            dt = lglg.Dangnhap(lgo);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap tc");
                return; 

            }
            else
                MessageBox.Show("Dn that bai");

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

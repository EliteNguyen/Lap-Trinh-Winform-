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
    public partial class frmLoginTSX : Form
    {

        int flag = -1;
        LoginLogic lglg = new LoginLogic();
        DataTable dt ;
        public frmLoginTSX()
        {
            InitializeComponent();
        }

        void setEnable (bool b)
        {
            btnLuu.Enabled = !b;
            btnBoQua.Enabled = !b;
            txtPass.Enabled = !b;
            txtUser.Enabled = !b;

            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

        }

        private void frmLoginTSX_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dt = lglg.HienThi();
            dgvLg.DataSource = dt;
            setEnable(true);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setEnable(false);
            flag = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnable(false);
            flag = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          //  setEnable(false);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            setEnable(true);
            flag = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if(flag==1)
            {
                MessageBox.Show("them vao ");
            }
            else
            {
                MessageBox.Show("sua du lieu ");
            }
            setEnable(true);
        }
    }
}

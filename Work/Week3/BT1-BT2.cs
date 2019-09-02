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
    public partial class BT1 : Form
    {
        DataTable tbOder = new DataTable();
        public BT1()
        {
            InitializeComponent();
        }


        private void BT1_Load(object sender, EventArgs e)
        {
            tbOder.Columns.Add("FoodName",typeof(string));
            tbOder.Columns.Add("Quantity", typeof(int));

            grvDSMonAn.DataSource = tbOder;

            DataColumn[] Key = new DataColumn[1];
            Key[0] = tbOder.Columns["FoodName"];
            tbOder.PrimaryKey = Key;

        }

        private void btnPMB_Click(object sender, EventArgs e)
        {
            Button TenMon = (Button)(sender);
            DataRow r = tbOder.Rows.Find((string)TenMon.Text);

            if (r != null)
            {
                r["Quantity"] = (int)r["Quantity"] + 1;
            }
            else
            {
                r = tbOder.NewRow();
                r["FoodName"] = TenMon.Text;
                r["Quantity"] = 1;
                tbOder.Rows.Add(r);
            }
 
        }
        private int ChonMon(DataTable dt, string TenMon)
        {
            int Row = -1;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(tbOder.Rows[i]["FoodName"].ToString() == TenMon)
                {
                    Row = i;
                    break;
                }
            }
            return Row;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(grvDSMonAn.SelectedRows.Count > 0)
            {
                string TenMon = grvDSMonAn.SelectedRows[0].Cells[0].Value.ToString();

                int Row = ChonMon(tbOder, TenMon);
                int Count = Convert.ToInt32(tbOder.Rows[Row]["Quantity"]);

                if(Count == 1)
                {
                    tbOder.Rows.RemoveAt(Row);
                }
                else
                {
                    tbOder.Rows[Row]["Quantity"] = Convert.ToInt32(tbOder.Rows[Row]["Quantity"]) - 1;
                }
                
            }
        }
    }
}

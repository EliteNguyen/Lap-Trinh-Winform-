using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWINFORM
{
    class LoginLogic
    {
        Database db =new Database();
        public DataTable Dangnhap( LoginObject lgo)

        {
            string sql = "SELECT * FROM LOGIN WHERE  [USERNAME] =N'" + lgo.Username + "' AND [PASSWORD] =N'" + lgo.Password + "'";
            DataTable dt = new DataTable();

            dt = db.Execute(sql);
            return dt;
        }


        public DataTable HienThi()
        {
            string sql = "SELECT * FROM LOGIN"; 
            DataTable dt = new DataTable();

            dt = db.Execute(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    interface IBook
    {
        //Mô tả Index chương sách
        string this[int index]
        {
            get;
            set;
        }

        //Properties Title - Tên sách
        string Title
        {
            get;
            set;
        }
        //Properties Author - Tên Tác giả
        string Author
        {
            get;
            set;
        }
        
        //Properties Publisher - Tên NXB
        string Publisher
        {
            get;
            set;
        }

        string ISBN
        {
            get;
            set;
        }
        //Properties Year- Năm XB
        int Year
        {
            get;
            set;
        }
        //Phương thức hiển thị thông tin sách
        void Show();
    }
}

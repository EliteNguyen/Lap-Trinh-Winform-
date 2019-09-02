using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList BL = new BookList();
            BL.InputList();
            BL.ShowList();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Book : IBook
    {
        //Dữ liệu thành viên
        #region Định nghĩa Dữ liệu
        private string title;
        private string author;
        private string publisher;
        private string isbn;
        private int year;

        //Lưu trữ mảng chứa tên chương
        private ArrayList chapter = new ArrayList();
        private string iSBN;
        #endregion

        #region Thực thi giao diện iBook
        public string this[int index] //Indexer chương sách
        {
            get
            {
                if (index >= 0 && index <= chapter.Count)
                {
                    return (string)chapter[index];
                }
                else
                {
                    //Phát sinh ngoại lệ
                    throw new IndexOutOfRangeException("Không tồn tại Chapter này!");
                }
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value; //Cập nhật lại chương
                }
                else if (index == chapter.Count)
                {
                    chapter.Add(value); //Thêm chương mới
                }
                else //Phát sinh ngoại lệ
                {
                    throw new IndexOutOfRangeException("Không tồn tại Chapter này!");
                }
            }
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public string ISBN
        {
            get
            {
                return iSBN;
            }

            set
            {
                iSBN = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("THONG TIN SACH");
            Console.WriteLine("---------------------");
            Console.WriteLine("Title {0}",title);
            Console.WriteLine("Author {0}",author);
            Console.WriteLine("Publisher {0}",publisher);
            Console.WriteLine("ISBN {0}",isbn);
            Console.WriteLine("Year {0}",year);
            Console.WriteLine("Chapter: ");
            for(int i= 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t {0}: {1}", i + 1, chapter[i]);
            }
            Console.WriteLine("----------------------");
        }

        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());

            string str;
            do //Nhập lần lượt các chương sách
            {
                str = Console.ReadLine();
                if(str.Length > 0)
                    chapter.Add(str);
                
            } while (str.Length > 0); //Kết thúc khi chuỗi rỗng
        }
        #endregion
    }
}

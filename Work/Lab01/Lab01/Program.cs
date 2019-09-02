using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class SinhVien
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        //Constructor mac dinh
        public SinhVien()
        {
            SID = 1;
            TenSV = "Bui Phu Khuyen";
            Khoa = "CNTT";
            DiemTB = 7.0f;
        }

        //Constructor sao chep
        public SinhVien(SinhVien stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        //Constructor tham so
        public SinhVien(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            TenSV = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }

        //Properties
        public int SID1
        {
            get
            {
                return SID;
            }

            set
            {
                SID = value;
            }
        }
        public string TenSV1
        {
            get
            {
                return TenSV;
            }

            set
            {
                TenSV = value;
            }
        }
        public string Khoa1
        {
            get
            {
                return Khoa;
            }

            set
            {
                Khoa = value;
            }
        }
        public float DiemTB1
        {
            get
            {
                return DiemTB;
            }

            set
            {
                DiemTB = value;
            }
        }

        //Phuong thuc hien thi du lieu
        public void Xuat1SV()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }

        public void Nhap1SV()
        {
            Console.Write("Nhap MSSV: ");
            SID1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho va Ten SV: ");
            TenSV1 = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa1 = Console.ReadLine();
            Console.Write("Nhap DTB: ");
            DiemTB1 = float.Parse(Console.ReadLine());
        }

    }
    class DSSV
    {
        SinhVien[] DS;
        public DSSV()
        {
            DS = new SinhVien[100];
        }

        public object Xuat1SV { get; private set; }

        public void NhapDS(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Thong Tin SV thu {0}:", i + 1);
                DS[i] = new SinhVien();
                DS[i].Nhap1SV();
            }
        }
        
        public void XuatDS(int n)
        {
            for(int i = 0; i < n; i++)
            { 
                DS[i].Xuat1SV();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DSSV DS = new DSSV();
            Console.Write("Nhap so luong SV:");
            int n = int.Parse(Console.ReadLine());
            DS.NhapDS(n);
            DS.XuatDS(n);
            Console.ReadLine();
        }
    }
}

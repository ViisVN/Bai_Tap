using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            student sv1 = new student();

            //Input sv1
            sv1.SetID(11111);
            sv1.SetName("Huynh Nhat Hao");
            sv1.SetLT(8.5);
            sv1.SetTH(9.0);

            //Input sv2
            student sv2 = new student(22222, "Be Van Dan", 7.5, 8.0);
            student sv3 = new student();

            //Input sv3
            sv3.SetID(ID());
            sv3.SetName(name());
            sv3.SetLT(LT());
            sv3.SetTH(TH());
            Console.WriteLine();
            Console.WriteLine();

            //Output danh sach sinh vien
            Console.WriteLine(string.Format("{0,-10}{1,-30}{2,-10}{3,-10}{4,-10}","Masv","hoten","diemlt","diemth","diemtb"));
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv3.ToString());

        }

        //Truy xuat ra tung muc de nhap thong tin
        static int ID()
        {
            Console.WriteLine("Nhap ma so cua sinh vien");
            again:
            int ID = Convert.ToInt32(Console.ReadLine());
            if(ID < 0)
            {
                Console.WriteLine("Ma so sinh vien phai lon hon khong- NHAP LAI");
                goto again;
            }
            Console.WriteLine();
            return ID;
        }
        static string name()
        {
            Console.WriteLine("Nhap ten sinh vien");
             again:
            string Name=Console.ReadLine();
            if(Name == null||Name=="")
            {
                Console.WriteLine("Phai nhap ten sinh vien - NHAP LAI");
                goto again;
            }
            Console.WriteLine();
            return Name;
        }
        static double LT()
        {
            Console.WriteLine("Nhap diem LT");
            again:
            double LT = Convert.ToDouble(Console.ReadLine());
            if(LT<0||LT>10)
            {
                Console.WriteLine("Diem so phai lon hon 0 hoac be hon 10 - NHAP LAI");
                goto again;
            }
            Console.WriteLine();
            return LT;
        }
        static double TH()
        {
            Console.WriteLine("Nhap diem TH");
            again:
            double TH = Convert.ToDouble(Console.ReadLine());
            if(TH<0||TH>10)
            {
                Console.WriteLine("Diem so phai lon hon 0 hoac be hon 10 - NHAP LAI");
                goto again;
            }
            Console.WriteLine();
            return TH;
        }
    }
}
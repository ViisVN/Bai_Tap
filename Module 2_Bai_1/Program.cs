using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhà_Xe
{
    class program
    {
        public static void Main(string[] ars)
        {
            //Nhap thong tin
            Tuyen_Xe_Ngoai_Thanh Ngoai1 = new Tuyen_Xe_Ngoai_Thanh("A197H", "Tran Van Lam", 7734, "Ha Noi", 3);
            Tuyen_Xe_Ngoai_Thanh Ngoai2 = new Tuyen_Xe_Ngoai_Thanh("A91AC", "Dinh Van Tai", 7734, "Hai Phong", 3);

            Tuyen_Xe_Noi_Thanh Noi1 = new Tuyen_Xe_Noi_Thanh("B351H", "Tran Van Lam", 3342, 7, 30);
            Tuyen_Xe_Noi_Thanh Noi2 = new Tuyen_Xe_Noi_Thanh("B13A3", "Dinh Van Tai", 3342, 1, 15);

            //Xuat ra thong tin
            Ngoai1.Info();
            Console.WriteLine();
            Ngoai2.Info();
            Console.WriteLine();
            Noi1.Info();
            Console.WriteLine();
            Noi2.Info();
            Console.WriteLine();

            //Tong doanh thu
            Console.WriteLine("Doanh thu noi thanh: {0,-1} ", (Noi1.getdoanhthu() + Noi2.getdoanhthu()));
            Console.WriteLine("Doanh thu ngoai thanh: {0,-1} ", (Ngoai1.getdoanhthu() + Ngoai2.getdoanhthu()));
            Console.WriteLine("Doanh thu: {0,-1} ", (Ngoai1.getdoanhthu() + Ngoai2.getdoanhthu() +Noi1.getdoanhthu() + Noi2.getdoanhthu()));



        }
    }    
}
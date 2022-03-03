using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhà_Xe
{
    public class Chuyen_xe
    {
        private string maSochuyen;
        private string hotentaixe;
        private int soxe;

        public Chuyen_xe(string maSochuyen, string hotentaixe, int soxe)
        {
            this.maSochuyen = maSochuyen;
            this.hotentaixe = hotentaixe;
            this.soxe = soxe;
        }
        public void info()
        {
            Console.WriteLine("Ma so chuyen: " + this.maSochuyen);
            Console.WriteLine("Ho ten tai xe: " + this.hotentaixe);
            Console.WriteLine("So xe: " + this.soxe);
        }


    }
    public class Tuyen_Xe_Noi_Thanh : Chuyen_xe
    {
        private int so_tuyen;
        private int km_diduoc;
        public Tuyen_Xe_Noi_Thanh(string maSochuyen, string hotentaixe, int soxe, int so_tuyen, int km_diduoc) : base(maSochuyen, hotentaixe, soxe)
        {
            this.so_tuyen = so_tuyen;
            this.km_diduoc = km_diduoc;
        }
        public void Info()
        {
            info();
            Console.WriteLine("So tuyen: " + this.so_tuyen);
            Console.WriteLine("Km di duoc: " + this.km_diduoc);
            Console.WriteLine(getdoanhthu());
        }
        public double setdoanhthu()
        {
            return 0;
        }
        public double getdoanhthu()
        {
            return this.km_diduoc * 10000;
        }
    }

    public class Tuyen_Xe_Ngoai_Thanh : Chuyen_xe
    {
        private string noi_den;
        private int ngay_di_duoc;

        public Tuyen_Xe_Ngoai_Thanh(string maSochuyen, string hotentaixe, int soxe, string noi_den, int ngay_di_duoc) : base(maSochuyen, hotentaixe, soxe)
        {
            this.noi_den = noi_den;
            this.ngay_di_duoc = ngay_di_duoc;
        }
        public void Info()
        {
            info();
            Console.WriteLine("Noi den: " + this.noi_den);
            Console.WriteLine("Ngay di duoc: "+this.ngay_di_duoc);
            Console.WriteLine(getdoanhthu());
        }
        public double setdoanhthu()
        {
            return 0;
        }

        public double getdoanhthu()
        {
            return this.ngay_di_duoc * 300000;
        }    
            
    }
}

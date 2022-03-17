    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class tam_giac
    {
        private int ma;
        private int mb;
        private int mc;

        public void seta(int ma)
        {
            if (ma < 0)
            {
                ma = this.ma;
            }
            else
            {
                this.ma = ma;
            }
        }
        public void setb(int mb)
        {
            if (mb < 0)
            {
                mb = this.mb;
            }
            else { this.mb = mb; }

        }
        public void setc(int mc)
        {
            if (mc < 0)
            {
                mc = this.mc;
            }
            else { this.mc = mc; }
        }
        // Neu co so lieu sai thi toan bo so lieu tro ve 0
        public tam_giac(int ma, int mb,int mc)
        {
            if (ma < 0||mb<0||mc<0||(ma+mb)<mc||(mb+mc)<ma||(ma+mc)<mb)
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }    
            else
            {
                seta(ma);
                setb(mb);
                setc(mc);
            }    
        }
        public tam_giac()
        {

        }
        //Chu vi tam giac
        public int chu_vi()
        {
            if (loai_tam_giac() == "Khong phai tam giac")
            {
                return 0;
            }
            else
            {
                return this.ma + this.mb + this.mc;
            }
        }
        //Dien tich tam giac
        public double dien_tich()
        {
            return Math.Sqrt((chu_vi() - this.ma) * (chu_vi() - this.mb) * (chu_vi() - this.mc));
        }
        //Ra cac dieu kien de xet kieu tam giac
        public string loai_tam_giac()
        {
            string loai = null;
            if (this.ma <= 0 || this.mb <= 0 || this.mc <= 0 || (this.ma + this.mb) < this.mc || (this.mb + this.mc) < this.ma || (this.ma + this.mc) < this.mb)
            {
                loai = "Khong phai tam giac";               
            }    
            else if(this.ma==this.mb && ma!=0 && this.ma!= this.mc|| this.mc == this.mb && mb != 0 && this.mb != this.ma|| this.ma == this.mc && ma != 0 && this.ma != this.mb)
            {
                loai = "Tam giac can";
            }
            else if(this.ma == this.mb && this.mc==this.mb)
            {
                loai = "Tam giac deu";
            }    
            else
            {
                loai = "Tam giac thuong";
            }
            return loai;
            
        }
        public override string ToString()
        {
            return $"- Canh a: {this.ma} \n- Canh b: {this.mb} \n- Canh c: {this.mc} \n- Kieu: {loai_tam_giac()} \n- Chu vi: {chu_vi()} \n- Dien tich: {dien_tich()} ";
        }
    }
}

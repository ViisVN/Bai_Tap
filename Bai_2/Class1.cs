using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class student
    {
        private int ID;
        private string name;
        private double LT;
        private double TH;

        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetLT(double LT)
        { 
            this.LT = LT;
        }
        public void SetTH(double TH)
        {
            this.TH = TH;
        }

        public student()
        { }
        public student(int ID, string name, double LT, double TH)
        {
            SetID(ID);
            SetName(name);
            SetLT(LT);
            SetTH(TH);
        }

        public int GetID()
        { return ID; }
        public string GetName()
        { return name; }
        public double GetLT()
        {
            return Math.Round(this.LT, 2);
        }
        public double GetTH()
        {
            return Math.Round(TH, 2);
        }

        public double TB()
        {

            return Math.Round(((this.LT + this.TH) / 2), 1);
        }
        public override string ToString()
        {         
            return string.Format("{0,-10}{1,-30}{2,-10}{3,-10}{4,-10}", this.ID, this.name, string.Format("{0:0.0}", this.LT), string.Format("{0:0.0}", this.TH), TB());
        }
    }
}

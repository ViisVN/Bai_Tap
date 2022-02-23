using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    class coodinator 
    {
        private int x;
        private int y;
        private string name;

        public void SetX(int x)
        { this.x = x; }
        public void SetY(int y)
        { this.y = y; }
        public void SetName(string name)
        { this.name = name; }

        public coodinator(int x, int y, string name)
        {
            SetX(x);
            SetY(y);
            SetName(name);
        }
        public coodinator()
        { }
        public int GetX()
        { return x; }
        public int GetY()
                { return y; }
        public string GetName()
            { return name; }

        public override string ToString()
        {
            return $"{this.name}({this.x},{this.y})";
        }
    }
}

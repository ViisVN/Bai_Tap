using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            coodinator coodinator = new coodinator();
            coodinator coodinator2 = new coodinator(1, 2, "Team1");

            //Gan gia tri 
            coodinator.SetX(2);
            coodinator.SetY(4);
            coodinator.SetName("Team");

            //Lay cai gia tri ra
            Console.WriteLine(coodinator.GetX());
            Console.WriteLine(coodinator.GetY());
            Console.WriteLine(coodinator.GetName());

            //Overdirve
            Console.WriteLine(coodinator.ToString());
            Console.WriteLine(coodinator2.ToString());
        }
    }
}
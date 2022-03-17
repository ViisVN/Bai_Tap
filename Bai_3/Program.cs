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
            tam_giac tam_giac1 = new tam_giac(1, 2, 3);
            tam_giac tam_giac2 = new tam_giac(0, 1, 2);
            tam_giac tam_giac3 = new tam_giac(5, 5, 4);
            tam_giac tam_giac4 = new tam_giac(8, 8, 8);
            tam_giac tam_giac5 = new tam_giac(10, 50, 11);


            Console.WriteLine(tam_giac1.ToString());
            Console.WriteLine();
            Console.WriteLine(tam_giac2.ToString());
            Console.WriteLine();
            Console.WriteLine(tam_giac3.ToString());
            Console.WriteLine();
            Console.WriteLine(tam_giac4.ToString());
            Console.WriteLine();
            Console.WriteLine(tam_giac5.ToString());
            Console.WriteLine();


        }
    }
}
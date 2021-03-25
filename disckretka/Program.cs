using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disckretka
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = "", s = "", r1 = "", s1 = "";
            string t1 = "", t2 = "";
            int x = 1;
            double y;
            //R
            for (int i = 0; i < 10;i++)
            {
                y = 2 * x + 4;
                r += $"({x};{y})";
                x++;     
            }

            //S
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = Math.Pow(x,2);
                s += $"({x};{y})";
                x++;
            }

            //R-1
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = 2 * x + 4;
                r1 += $"({y};{x})";
                x++;
            }

            //S-1
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = Math.Pow(x, 2);
                s1 += $"({y};{x})";
                x++;
            }

            //T1
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = 2*x*(1+2*x);
                t1 += $"({x};{y})";
                x++;
            }

            //T2
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = Math.Pow(2*x,2)+Math.Pow(4*x,2);
                t2 += $"({x};{y})";
                x++;
            }

            Console.WriteLine($"R:{r}");
            Console.WriteLine($"S:{s}");
            Console.WriteLine($"R-1:{r1}");
            Console.WriteLine($"S-1:{s1}");
            Console.WriteLine($"T1:{t1}");
            Console.WriteLine($"T2:{t2}");
            Console.ReadKey();
        }
    }
}

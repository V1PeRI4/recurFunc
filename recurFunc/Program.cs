////////
///  Вычислить значение y(n) =  √1+√2+√n 
///  Корень с каждым разом ниже уровнем
///////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Func(int x, int m)
            {

                if (x == m) return Math.Sqrt(x);

                return Math.Sqrt(m + Func(x, m + 1));
            }

            Console.Write("Введите n: ");
            int n = Console.Read();
            Console.WriteLine(Func(n, 1));

            Console.ReadKey();

        }
    }
}

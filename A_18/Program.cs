using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] wektor1 = { 5, 6, -1 };
            double[] wektor2 = { 0, 2, 3 };
            double wynik = 0;
            for (int i = 0; i < 3; i++)
            {
                wynik += wektor1[i] * wektor2[i];
            }
            Console.WriteLine("Iloczyn skalarny: {0}", wynik);
            Console.ReadKey();
        }
    }
}

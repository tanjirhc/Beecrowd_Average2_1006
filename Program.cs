using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Average2_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("MEDIA = " + ((A * 2 + B * 3 + C * 5) / (2 + 3 + 5)).ToString("0.0"));
            Console.ReadKey();
        }
    }
}

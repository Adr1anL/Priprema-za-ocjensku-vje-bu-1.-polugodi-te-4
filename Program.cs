using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;

            Console.WriteLine("Unesi jedan decimalan i jedan cijeli broj: ");

            string[] a = Console.ReadLine().Split(' ');

            try
            {
                x = Convert.ToDouble(a[0]);
                y = Convert.ToDouble(a[a.Length - 1]);

                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            catch (Exception)
            {
                Console.WriteLine("U unosu nisu brojevi!");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cerchio a = Cerchio.Parse(Console.ReadLine());
            Cerchio b = Cerchio.Parse(Console.ReadLine());
            Cerchio somma = a + b;
            Console.WriteLine("{0}", somma);
            Console.ReadLine();
            if (a==b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}

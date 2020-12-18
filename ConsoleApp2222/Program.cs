using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2222
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(" 'a' enter");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("'b'  enter");
                double b = double.Parse(Console.ReadLine());
                double p = a + b + Math.Sqrt(a * a + b * b);
                double s = a * b / 2.0;
                Console.WriteLine("Square " + s);
                Console.ReadLine();
            }
        }
    }
}

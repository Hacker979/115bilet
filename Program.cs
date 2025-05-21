using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void VOD()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        static void Main(string[] args)
        {
            VOD();
            Console.Read();
        }
    }
}

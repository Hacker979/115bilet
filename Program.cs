using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void N1()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        static void N2()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
        }
        static void N3()
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x:F1} * {y:F1} = {(x * y):F1}");
        }
        static void N4()
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"{x:F3} / {y:F3} = {(x / y):F3}");
        }
        static void N5()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {y} + {x}");
        }
        static void N6()
        {
            Console.Write("a = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        static void N8()
        {
            Console.Write("Номинал купюры = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Количество купюр = ");
            float y = float.Parse(Console.ReadLine());
            string z = string.Format("{0:C2}", (x * y));
            Console.WriteLine($"Сумма денег = {z}");
        }
        static void Main(string[] args)
        {
            //N1();
            //N2();
            //N3();
            //N4();
            //N5();
            //N6();
            N8();
            Console.Read();
        }
    }
}

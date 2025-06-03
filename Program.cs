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
        static void N7()
        {
            Console.Write("как тебя зовут? ");
            string x = Console.ReadLine();
            Console.Write("Сколько тебе лет? ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x}, ты родился в {2025-y} году.");
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
        static void N36()
        {
            Console.WriteLine("x\t|\ty\n_\t|\t_");
            for (int x = 1; x <= 20; x += 2)
            {
                int y = 5 * x - 2;
                Console.WriteLine($" {x}\t|\t{y}\n_\t|\t_\n");
            }
        }
        static void N22()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0) Console.WriteLine($"число {a} делитель трем ");
            else Console.WriteLine($"число {a} не делитель трем ");
        }
        static void N23()
        {
            Random r = new Random();
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                a = r.Next(-30, 30); ;
                Console.WriteLine(a > 0 ? (a + "-положительное") : (a + "-отрицательное"));
            }
        }
        static void N24()
        {
            Random r = new Random();
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                a = r.Next(-20,30); ;
                Console.WriteLine(a % 2 == 0? (a + "-четное"): (a + "-нечетное")) ;
            }
        }
        static void N25()
        {
            Random r = new Random();
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                a = r.Next(-20, 20); ;
                Console.Write(a > 0 ? a % 2 == 0 ? (a + "-четное\n") : (a + "-нечетное\n") : "");
            }
        }
        static void N27()
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Не верный день недели");
                    break;
            }
        }
        static void N44()
        {
            for (int i = 102; i<200; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        static void N40()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
        }

        //подсчитать количество двух знач чисел кратвых 11 и вывести в столбик
        static void NNN()
        {
            int a = 0;
            for (int i = 11; i < 100; i+=11)
            {
                Console.WriteLine(i);
                a++;
            }
            Console.WriteLine("Количетсво "+a);
        }
        //подсчитать количество цифр веденного числа
        static void NNN2()
        {
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            while (a > 0)
            {
                a = a / 10;
                i++;
            }
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            //N1();
            //N2();
            //N3();
            //N4();
            //N5();
            //N6();
            //N8();
            //N36();
            //N24();
            //N27();
            //N44();
            //N40();
            //NNN();
            //NNN2();
            //N7();
            //N23();
            //N25();
            N22();
            Console.Read();
        }
    }
}

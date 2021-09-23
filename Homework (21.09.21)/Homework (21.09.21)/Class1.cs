using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__21._09._21_
{
    class Run
    {
        static void Main(string[] args)
        {
            Class1.One();
            //Class1.Two();
            //Class1.Three();
            //Class1.Four();
            //Class1.Five();
            //Class1.Six();
        }
    }

    class Class1
    {

        public static void One()
        {
            Console.WriteLine("Введите скидку:");
            decimal x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество денег, которые вы готовы потратить:");
            decimal n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n - (n * (x / 100)));
            Console.ReadLine();
        }



        public static void Two()
        {
            Console.WriteLine("Сколько мест в театре?");
            decimal y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Сколько было продано билетов?");
            decimal x = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{(x / y) * 100}%");
            Console.ReadLine();
        }



        public static void Three()
        {
            for (int z = 1; z < 10; z++)
            {
                for (int t = 0; t < 10; t++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        for (int r = 1; r < 10; r++)
                        {
                            for (int s = 0; s < 10; s++)
                            {
                                if ((z * 100) + (t * 10) + y + (r * 1000) + (z * 100) + (y * 10) + r == (s * 1000) + (z * 100) + (r * 10) + z)
                                {
                                    Console.WriteLine($"{z}{t}{y} + {r}{z}{y}{z} = {s}{z}{r}{z}");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }



        public static void Four()
        {
            for (int i = 1000; i < 10000; i++)
            {
                if (((i / 1000) != (i % 1000 / 100)) && ((i % 1000 % 100 / 10) != (i % 1000 % 100 % 10)) && ((i / 1000) != (i % 1000 % 100 / 10)) && ((i % 1000 / 100) != (i % 1000 % 100 % 10)) && ((i % 1000 / 100) != (i % 1000 % 100 / 10)) && ((i / 1000) != (i % 1000 % 100 % 10)))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }



        public static void Five()
        {
            Console.WriteLine("Введите четырёхзначное число");
            int i = Int32.Parse(Console.ReadLine());
            if (((i / 1000) == (i % 1000 / 100)) || ((i % 1000 % 100 / 10) == (i % 1000 % 100 % 10)) || ((i / 1000) == (i % 1000 % 100 / 10)) || ((i % 1000 / 100) == (i % 1000 % 100 % 10)) || ((i % 1000 / 100) == (i % 1000 % 100 / 10)) || ((i / 1000) == (i % 1000 % 100 % 10)))
            {
                Console.WriteLine("Да, есть повторяющиеся цифры");
            }
            else
            {
                Console.WriteLine("Нет повторяющихся цифр");
            }
            Console.ReadLine();
        }



        public static void Six(string[] args)
        {
            for (int i = 20; i < 51; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }

}

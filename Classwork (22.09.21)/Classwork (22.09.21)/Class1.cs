using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork__22._09._21_
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Cw.One();
            //Cw.Two();
            //Cw.Three();
            //Cw.Four();
            Cw.Five();
        }
    }

    class Cw
    {
        public static void One()
        {
            Console.WriteLine("Введите ваш пол");
            string s = Console.ReadLine();
            switch (s)
            {
                case "М":
                    Console.WriteLine("Введите ваш рост");
                    double l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((l  - 100) * 1.15);
                    break;
                case "Ж":
                    Console.WriteLine("Введите ваш рост");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((l - 110) * 1.15);
                    break;
                case "м":
                    Console.WriteLine("Введите ваш рост");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((l - 100) * 1.15);
                    break;
                case "ж":
                    Console.WriteLine("Введите ваш рост");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((l - 110) * 1.15);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }



         public static void Two()
        {
            Console.WriteLine("Введите колличество цифр в числе");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[b];
            Console.WriteLine($"Введите {b} цфир(-ы)");
            for (int i = 0; i < b; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = b-1; i > -1; i--)
            {
                Console.Write(array[i]);
            }
            Console.ReadLine();

        }



        public static void Three()
        {
            bool k = false;
            Console.WriteLine("Введите колличество цифр в массиве");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[b];
            Console.WriteLine($"Введите {b} цфир(-ы)");
            for (int i = 0; i < b; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < b; i++)
            {
                if ((array[i] == 1) && (array[i+1] == 2) && (array[i + 2] == 3))
                {
                    k = true;
                }
            }
            if (k == true)
            {
                Console.WriteLine("Да, есть последовательность 123");
            }
            else
            {
                Console.WriteLine("Нет последовательности 123");
            }
            Console.ReadLine();
        }



        public static void Four()
        {
            bool m = false;
            bool n = false;
            int k = 0;
            int k2 = 0;
            Console.WriteLine("Введите колличество чисел в массиве");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[b];
            Console.WriteLine($"Введите {b} числа (чисел)");
            for (int i = 0; i < b; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < b; i++)
            {
                int v = array[i];
                if (v != 6)
                {
                    k = v + k;
                    if ((v == 7) && (m == true))
                    {
                        k -= k2;
                        k -= 7;

                        m = false;
                        n = false;
                    }
                    if (n == true)
                    {
                        k2 += v;
                    }
                }
                else
                {
                    k += v;
                    k2 += v;
                    m = true;
                    n = true;
                }
            }
            Console.WriteLine(k);
            Console.ReadLine();
        }


        public static void Five()
        {

        }
        
    }
}

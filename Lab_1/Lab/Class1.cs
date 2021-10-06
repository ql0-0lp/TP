using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Cw.One();
            //Cw.Two();
            //Cw.Three();
            //Cw.Four();
            //Cw.Five();
            //Cw.Six();
            Cw.Seven();
            //Cw.Eight();
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
                    Console.WriteLine((l - 100) * 1.15);
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
            int k = 0;
            Console.WriteLine("Введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            int b2 = b;
            while (b2 != 0)
            {
                b2 /= 10;
                k++;
            }
            for (int i = 1; i < k+1; i++)
            {
                b2 = (b % Convert.ToInt32(Math.Pow(10, i))) / Convert.ToInt32(Math.Pow(10, i - 1));
                Console.Write(b2);
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
                if ((array[i] == 1) && (array[i + 1] == 2) && (array[i + 2] == 3))
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
            Console.WriteLine("Введите размер квадратной матрицы:");
            int r = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[r, r];
            int i = (r - 1) / 2;
            int j = i;
            array[i, j] = 1;
            bool n = true;
            int m = 2;
            while (m != r+1)
            {
                if (n == true) 
                {
                    for (int k = 1; k < m; k++)
                    {
                        j++;
                        array[i, j] = array[i, j-1] + 1; 
                    }
                    for (int k = 1; k < m; k++)
                    {
                        i++;
                        array[i, j] = array[i - 1, j] + 1;
                    }
                    n = false;
                    m++;
                }
                else
                {
                    for (int k = 1; k < m; k++)
                    {
                        j--;
                        array[i, j] = array[i, j + 1] + 1;
                    }
                    for (int k = 1; k < m; k++)
                    {
                        i--;
                        array[i, j] = array[i + 1, j] + 1;
                    }
                    n = true;
                    m++;
                }
            }
            for ( j = 1; j < r; j++)
            {
                array[i, j] = array[i, j - 1] + 1;
            }
            int g = 1;
            int sum = 0;
            i = r - 1;
            j = 0;
            while (g < r+1)
            {
                for (int h = 0; h < r; h++)
                {
                    sum += array[i, j];
                    i--;
                    j++;
                    g++;
                }
            }
            g = 2;
            i = r - 1;
            j = r - 1;
            while (g < r+1)
            {
                for (int h = 0; h < r; h++)
                {
                    sum += array[i, j];
                    i--;
                    j--;
                    g++;
                }
            }
            Console.WriteLine(sum-1);
            Console.ReadLine();
        }



        public static void Six()
        {
            Console.WriteLine("Какое будет количество ходов?");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] pep = new int[c];
            int[] machine = new int[c];
            int sum_pep = 0;
            int sum_machine = 0;
            Random rnd = new Random();
            Console.WriteLine("Нажмите Enter чтобы бросить кубик");
            for (int i = 0; i < c; i++)
            {
                Console.ReadLine();
                pep[i] = rnd.Next(1, 6);
                Console.WriteLine(pep[i]);
                sum_pep += pep[i];

            }
            for (int i = 0; i < c; i++)
            {
                machine[i] = rnd.Next(1, 6);
                Console.WriteLine(machine[i]);
                sum_machine += machine[i];
            }
            Console.WriteLine("Игрок\tКомпьютер");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}\t{1}", pep[i], machine[i]);
            }
            Console.WriteLine("----------");
            Console.WriteLine("{0}\t{1}", sum_pep, sum_machine);
            Console.ReadLine();

        }



        public static void Seven()
        {
            Random rnd = new Random();
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            int p = 0;
            int m = 0;
            int l = 0;
            string[] count_p = new string[3];
            string[] count_m = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите номер: ");
                Console.WriteLine("1 - Камень; 2 - Ножницы; 3 - Бумагу");
                int pep = Convert.ToInt32(Console.ReadLine());
                int machine = rnd.Next(1, 3);
                switch (pep)
                {
                    case 1:
                        if (machine == 2)
                        {
                            Console.WriteLine($"Победил {name}");
                            count_p[l] = "Победа";
                            count_m[l] = "Проигрыш";
                            l++;
                            p++;
                        }
                        else
                        {
                            Console.WriteLine($"К сожалению, {name} проиграл");
                            count_m[l] = "Победа";
                            count_p[l] = "Проигрыш";
                            l++;
                            m++;
                        }
                        break;
                    case 2:
                        if (machine == 3)
                        {
                            Console.WriteLine($"Победил {name}");
                            count_p[l] = "Победа";
                            count_m[l] = "Проигрыш";
                            l++;
                            p++;
                        }
                        else
                        {
                            Console.WriteLine($"К сожалению, {name} проиграл");
                            count_m[l] = "Победа";
                            count_p[l] = "Проигрыш";
                            l++;
                            m++;
                        }
                        break;
                    case 3:
                        if (machine == 1)
                        {
                            Console.WriteLine($"Победил {name}");
                            count_p[l] = "Победа";
                            count_m[l] = "Проигрыш";
                            l++;
                            p++;
                        }
                        else
                        {
                            Console.WriteLine($"К сожалению, {name} проиграл");
                            count_m[l] = "Победа";
                            count_p[l] = "Проигрыш";
                            l++;
                            p++;
                        }
                        break;
                }
            }
            Console.WriteLine("----------");
            Console.WriteLine("Игрок\tКомпьютер");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}\t{1}", count_p[i], count_m[i]);
            }
            Console.WriteLine("----------");
            if (p > m)
            {
                Console.WriteLine($"Игру выигра {name}");
            }
            else
            {
                Console.WriteLine($"{name} проиграл игру :(");
            }
            Console.ReadLine();
        }



        public static void Eight()
        {
            Random rnd = new Random();
            int k = 0;
            int q = 0;
            int p = 0;
            int a = rnd.Next(1, 20);
            int b = rnd.Next(1, 10);
            int[] array_1 = new int[a];
            int[] array_2 = new int[b];
            for (int i = 0; i < a; i++)
            {
                array_1[i] = rnd.Next(0, 9);
                if (array_1[i] % 2 != 1)
                {
                    array_1[q] = array_1[i];
                    q++;
                    k++;
                } 
            }
            for (int i = 0; i < b; i++)
            {
                array_2[i] = rnd.Next(0, 9);
                if (array_2[i] % 2 != 1)
                {
                    array_2[p] = array_2[i];
                    p++;
                    k++;
                }
            }
            int[] array_3 = new int[k];
            for (int i = 0; i < q; i++)
            {
                array_3[i] = array_1[i];
            }
            for (int i = 0; i < p; i++)
            {
                array_3[q] = array_2[i];
                q++;
            }
            for (int i = 0; i < b; i++)
            {
                Console.Write(array_3[i]);
            }
            Console.ReadLine();
        }

    }
}

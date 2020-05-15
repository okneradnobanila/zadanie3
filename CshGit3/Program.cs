using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshGit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Выберите номер действия:\n\n 1) Найти номер минимального по модулю элемента массива." +
                "\n\n 2) Найти и вывести уникальные элементы массива." +
                "\n\n 3) Заполнить массив случайными положительными и отрицательными целыми числами. " +
                "Вывести его на экран. Удалить из массива все отрицательные элементы и снова вывести.\n");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("\n Введите число элементов массива: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Double[] mass = new double[a];

                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(" Введите элемент массива: ");
                    mass[i] = double.Parse(Console.ReadLine());
                    mass[i].ToString();
                }

                int j = 0;
                double min = mass[0];
                for(int i = 0; i < a; i++)
                {
                    if(Math.Abs(mass[i]) < Math.Abs(min))
                    {
                        min = mass[i];
                        j = i;
                    }
                }
                Console.WriteLine("\n Минимальный элемент: " + min.ToString() + ", номер минимального элемента: " + (j + 1).ToString());
            }

            if (num == 2)
            {
                Console.WriteLine("\n Введите число элементов массива: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Double[] mass = new double[a];

                int s = 0;
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(" Введите элемент массива: ");
                    mass[i] = double.Parse(Console.ReadLine());
                }

                for(int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        s = 1;
                        if (mass[i] == mass[j] && i != j)
                        {
                            s = 2;
                            break;
                        }
                    }
                    if (s == 1)
                    {
                        Console.WriteLine("\n " + mass[i] + " - является НЕ повторяющимся элементом\n");
                    }
                }
            }

            if (num == 3)
            {
                Console.WriteLine("\n Введите число элементов массива: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Double[] mass = new double[a];

                Console.WriteLine("\n Введите левую границу диапазона элементов массива: ");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Введите правую границу диапазона элементов массива: ");
                int max = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                int p = 0;
                Console.WriteLine("\n Массив из случайных целых чисел диапозона [" + min + ";" + max + "]: ");
                for (int i = 0; i < a; i++)
                {
                    mass[i] = int.Parse(rnd.Next(min, max).ToString());
                    Console.WriteLine(mass[i]);
                    if (mass[i] < 0)
                    {
                        p++;
                    }

                }

// пыталась перенести положительные числа в новый массив, но что-то как-то не очень получилось

                double[] mass2 = new double[p];
              
                for(int i=0; i < a; i++)
                {
                    for (int j = 0; j < p; j++)
                    {

                        if (p > 0)
                        {
                            if (mass[i] >= 0)
                            {
                                mass2[j] = mass[i];
                            }
                        }
                    }
                }

                Console.WriteLine("Массив БЕЗ отрицательных элементов: ");
                for(int i = 0; i < p; i++)
                {
                   Console.WriteLine( mass2[i]);
                }
                
            }
        }
    }
}

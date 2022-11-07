using System;

namespace _3rdLab
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Task 6: ");
            int p, summ, midnum, p_num, n;
            double mid;

            summ = 0;
            midnum = 0;
            p_num = 0;

            Console.Write("Введите количество элементов в массиве: \t");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                int[] mas6 = new int[n];

                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < mas6.Length; i++)
                {
                    Int32.TryParse(Console.ReadLine(), out mas6[i]);
                }

                Console.Write("Введите число P: \t");
                Int32.TryParse(Console.ReadLine(), out p);

                for (int i = 0; i < mas6.Length; i++)
                {
                    if (mas6[i] == p)
                    {
                        p_num = i;
                    }

                    summ += mas6[i];
                }

                mid = summ / n;
                double savenum = mas6[0];

                for (int i = 0; i < n - 1; i++)
                {
                    double B1 = Math.Abs(mid - mas6[i]);

                    for (int j = i + 1; j < n; j++)
                    {
                        double B2 = Math.Abs(mid - mas6[j]);

                        if (B1 < B2 && B1 < savenum)
                        {
                            midnum = i;
                            savenum = B1;
                        }
                        
                        if (B2 < B1 && B2 < savenum)
                        {
                            midnum = j;
                            savenum = B2;
                        }
                        
                    }
                }

                Console.WriteLine($"Midnum = {midnum}");

                mas6[p_num] = 0;
                int res_i = 0;

                for (int i = p_num; i > midnum + 1; i--)
                {
                    mas6[i] = mas6[i - 1];
                }

                mas6[midnum + 1] = p;

                Console.WriteLine("Полученный массив - ");
                for (int j = 0; j < mas6.Length; j++)
                {
                    Console.WriteLine(mas6[j]);
                }
            }

        }
    } 
}
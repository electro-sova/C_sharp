using System;

namespace ConsoleApp312
{
    class Program
    {
        static int max(ref int[,] a)
        {
            int n = a.GetLength(0);
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - i - 1 || i == j)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }

                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ВВЕДИТЕ n");
            while (!int.TryParse(Console.ReadLine(), out n) || (n < 3) || (n > 25) || (n % 2 == 0))
            {
                Console.WriteLine("ТОЛЬКО НЕЧЕТНЫЕ ЧИСЛА ОТ 3 ДО 25");
            }
            int[,] a = new int[n, n];


            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - i - 1 || i == j)
                    {
                        a[i, j] = r.Next(100);
                        Console.Write("{0} \t", a[i, j]);
                    }
                    else
                    {
                        a[i, j] = 0;
                        Console.Write("{0} \t", a[i, j]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine(max(ref a));

            Console.ReadKey();
        }

    }
}

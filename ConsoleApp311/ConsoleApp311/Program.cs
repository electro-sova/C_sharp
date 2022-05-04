using System;

namespace лаба3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, x, a, b, e;
            Console.WriteLine("введите n");
            while (!int.TryParse(Console.ReadLine(), out n) || (n > 100) || (n <= 0))
                Console.WriteLine("Ошибка ввода n должно быть больше 100 и меньше либо равно 0");
            Console.WriteLine("введите a");
            while (!int.TryParse(Console.ReadLine(), out a) || (a > 100) || (a < -100))
                Console.WriteLine("Ошибка ввода a должно быть больше 100 и меньше -100");
            Console.WriteLine("введите b");
            while (!int.TryParse(Console.ReadLine(), out b) || (b > 100) || (b < -100) || (b < a))
                Console.WriteLine("Ошибка ввода b должно быть больше 100 и меньше -100 и меньше а");
            //стандартное введение переменных
            int[] mas = new int [n]; //создание массива
            x = n;
            k = 0;
            e = 0; //просто всякая работа с переменными
            while (x > 0)
            {
                Random rnd = new Random();

                mas[k] = rnd.Next(a, b);
                //заполняем цикл случайными значениями
                Console.Write("{0} ", mas[k]); //тут я вывел цикл, чтобы было видно, что он там нарандомизировал и видеть последний отрицательный
                if (mas[k] < 0)
                {
                    e = mas[k];//этот цикл перебирает весь массив с начала до конца и каждое отрицательное значение записывает в переменную
                }
                k++;
                x--;
            }
            Console.WriteLine();
            Console.WriteLine("{0}", e);//выводит итоговое значение
        }
    }
}
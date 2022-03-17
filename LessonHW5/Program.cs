using System;

namespace LessonHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя не более 10 целых положительных чисел.Пользователь может прекратить приём чисел, введя 0.
            //После прекращения приёма целых чисел(это происходит в случае если было введено 10 чисел, 
            //либо пользователь ввёл 0, чтобы не вводить все 10) 
            //подсчитать среднее значение целых положительных чисел кратных трём и вывести на консоль.

            Console.WriteLine("Введите целые, положительные числа, не более 10");

             

            int[] number = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                number[i] = n;
                

                if (n == 0)
                {
                    Console.WriteLine("Готово");
                    break;
                }
                else
                {
                    Console.WriteLine($"Добавили ваше число: {n}");
                }
            }

            foreach (int n in number)
            {
                
                if(n == 0)
                {
                    
                    break;
                }
                Console.WriteLine($"Ваше число : {n}");
            }

            var summ = 0;

            int count = 0;

            foreach (int n in number)
            {
                if (n % 3 == 0 && n !=0)
                {
                    summ += n;
                    count++;
                }
            }

            var sred = summ / count;

            Console.WriteLine($"Среднее значение ваших чисел кратных 3 : {sred}");
            Console.ReadLine();

            Console.ReadLine();






        }
    }
}

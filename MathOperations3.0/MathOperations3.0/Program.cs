using System;

namespace MathOperations3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 34

            Console.WriteLine("Задача 34");
            int[] array34 = SozdanieMassiva();

            Console.WriteLine();

            Console.WriteLine("Количество четных чисел в массиве");
            ProverkaNaChetnost(array34);
            

            // Задача 36

            Console.WriteLine("Задача 36");
            int[] array36 = SozdanieMassiva();

            Console.WriteLine();

            Console.WriteLine("Сумма нечетных элементов массива");
            SummaNechet(array36);
            
            // Задача 38

            Console.WriteLine("Задача 38");
            double[] array38 = SozdanieMassivaVeshestv();

            Console.WriteLine();
            double result = MinMax(array38);

        }

        static int[] SozdanieMassiva()
        {

            int[] array = new int[10];
            Random rand = new Random();

            for (int y = 0; y < array.Length; y++)
            {
                array[y] = rand.Next(100, 1000);
                Console.WriteLine(array[y]);
            }

            return array;
        }

        static int ProverkaNaChetnost(int[] array)
        {
            int count = 0;

            for (int y = 0; y < array.Length; y++)
            {
                if (array[y] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        static int SummaNechet(int[] array)
        {
            int count = 0;

            for (int y = 0; y < array.Length; y++)
            {
                if (y % 2 == 1)
                {
                    count = count + array[y];
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
            return count;
        }

        static double[] SozdanieMassivaVeshestv()
        {

            double[] array = new double[10];
            Random rnd = new Random(); 

            for (int y = 0; y < array.Length; y++)
            {
                array[y] = rnd.NextDouble()* (10.00 - (-10.00)) + (-10.00);
                Console.WriteLine(array[y]);
            }

            return array;
        }

        static double MinMax(double[] array)
        {
            double min = 0;
            double max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            double raznost = max - min;

            Console.WriteLine();
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.WriteLine("Разность минимального и максимального значения:");
            Console.WriteLine(raznost);

            return raznost;
        }
    }
}
            
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Даны три массива размерностью m n p в каждом массиве определить сумму элементов кратных трём, произведение нечетных элементов,количество нулевых элементов(заполнение массивов выполнить с помощью функции, количество суммы и произведение тоже с помощью функции)//
namespace laba_6
{
    internal class Program
    {
        static int Nulik(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int Nech(int[] array)
        {
            int error = 0;
            int proizv = 1;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    proizv *= num;
                }
            }
            if (proizv > 1)
            {
                return proizv;
            }
            else
            {
                return error;
            }

        }
        static int Krat(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 3 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        static int[] Zapoln(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void Main()
        {
            int m, n, p, krat1 = 0, krat2 = 0, krat3 = 0, prnech1 = 0, prnech2 = 0, prnech3 = 0, countnul1 = 0, countnul2 = 0, countnul3 = 0;

            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            int[] array1 = new int[m];
            int[] array2 = new int[n];
            int[] array3 = new int[p];
            array1 = Zapoln(array1);
            array2 = Zapoln(array2);
            array3 = Zapoln(array3);
            krat1 = Krat(array1);
            krat2 = Krat(array2);
            krat3 = Krat(array3);
            prnech1 = Nech(array1);
            prnech2 = Nech(array2);
            prnech3 = Nech(array3);
            countnul1 = Nulik(array1);
            countnul2 = Nulik(array2);
            countnul3 = Nulik(array3);
            Console.WriteLine("Сумма кратных трём в первом массиве : " + krat1);
            Console.WriteLine("Сумма кратных трём во втором массиве : " + krat2);
            Console.WriteLine("Сумма кратных трём в третьем массиве : " + krat3);
            Console.WriteLine("Произведение нечётных элементов в первом массиве : " + prnech1);
            Console.WriteLine("Произведение нечётных элементов во втором массиве : " + prnech2);
            Console.WriteLine("Произведение нечётных элементов в третьем массиве : " + prnech3);
            Console.WriteLine("Количество нулей в первом массиве : " + countnul1);
            Console.WriteLine("Количество нулей во втором массиве : " + countnul2);
            Console.WriteLine("Количество нулей в тертьем массиве : " + countnul3);
            Console.ReadKey();
        }
    }
}

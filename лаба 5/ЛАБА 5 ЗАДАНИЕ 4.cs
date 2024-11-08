using System;
class HelloWorld
{
    static void Main()
    {
        int n, i, c = 0, d = 0, z = 0, srarifm = 0;
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (i = 0; i < n; i++)
        {
            d = array[i];
            if (d % 2 == 0)
            {
                c++;
                z += d;
            }
        }
        srarifm = z / c;
        Console.WriteLine(srarifm);
    }
}
//среднее арифметическое всех чётных чисел массива//
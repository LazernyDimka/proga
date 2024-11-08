using System;
class HelloWorld
{
    static void Main()
    {
        int n, i, c = 0;
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (i = 0; i < n; i++)
        {
            if (i != 0 && (array[i - 1] < array[i]))
            {
                c++;
            }
        }
        if (c == (n - 1))
        {
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
    }
}
// определить, находятся ли числа в порядке возрастания//
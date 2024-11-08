using System;
class HelloWorld
{
    static void Main()
    {
        int n, i, c = 0, d;
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (i = 0; i < n; i++)
        {
            d = array[i];
            while (d > 0)
            {
                c += d % 10;
                d /= 10;
            }
            Console.WriteLine(c);
            c = 0;
        }
    }
}
//нахождение суммы цифр чисел массива//
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
            if ((array[i] % 10 == 3) || (Math.Abs(array[i])) % 10 == 3)
            {
                c++;
            }
        }
        Console.WriteLine(c);
    }
}
//Количество чискл в массиве, которые заканчиваются на 3//
using System;
class HelloWorld
{
    static void Main()
    {
        int c = 1, n, max = 0, num, y = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 && num == y)
            {
                c++;
                if (c > max)
                {
                    max = c;
                }
                else
                {
                    c = 0;
                }
            }
            y = num;
        }
        Console.WriteLine(max);
    }
}
//найти наибольшую последовательность из нулей//
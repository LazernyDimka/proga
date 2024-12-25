using System;

class HelloWorld
{
    static void Main()
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = a;
        a = a - a + b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
/* Меняем значение двух переменных местами

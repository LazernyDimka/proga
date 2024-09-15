using System;

class HelloWorld
{
    static void Main()
    {
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a - a + b);
        Console.WriteLine(b - b + a);
    }
}
/* Меняем значение двух переменных местами

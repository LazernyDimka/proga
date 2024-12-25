}
        if (kolvo == 0)
{
    Console.WriteLine("Студенты не найдены");
}
    }
    
    static void ViborCourse(Student[] students)
{
    Console.WriteLine("\nВвeдите курс");
    int vibCourse = int.Parse(Console.ReadLine());
    int kolvo = 0;

    for (int i = 0; i < students.Length; i++)
    {
        if (vibCourse == students[i].Course)
        {
            Console.WriteLine("\n" + students[i]);
            kolvo++;
        }
    }
    if (kolvo == 0)
    {
        Console.WriteLine("Студенты не найдены");
    }
}

static void Main()
{
    Console.WriteLine("Введите количество студентов");
    int count = int.Parse(Console.ReadLine());
    Student[] students = new Student[count];
    bool a = true;
    while (a)
    {
        Console.WriteLine("\n" + "\tМеню");
        Console.WriteLine("1. Заполнение");
        Console.WriteLine("2. Модификация");
        Console.WriteLine("3. Поиск по году рождения");
        Console.WriteLine("4. Поиск по курсу");
        Console.WriteLine("5. Выход");

        int vibor = int.Parse(Console.ReadLine());

        if (vibor == 1)
        {
            FullStud(students);
        }
        else if (vibor == 2)
        {
            Mod(students);
        }
        else if (vibor == 3)
        {
            ViborYear(students);
        }
        else if (vibor == 4)
        {
            ViborCourse(students);
        }
        else if (vibor == 5)
        {
            a = false;
            break;
        }
        else
        {
            Console.WriteLine("Такой операции не существует");
        }
    }
}
}
}
        if (kolvo == 0)
{
    Console.WriteLine("�������� �� �������");
}
    }
    
    static void ViborCourse(Student[] students)
{
    Console.WriteLine("\n��e���� ����");
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
        Console.WriteLine("�������� �� �������");
    }
}

static void Main()
{
    Console.WriteLine("������� ���������� ���������");
    int count = int.Parse(Console.ReadLine());
    Student[] students = new Student[count];
    bool a = true;
    while (a)
    {
        Console.WriteLine("\n" + "\t����");
        Console.WriteLine("1. ����������");
        Console.WriteLine("2. �����������");
        Console.WriteLine("3. ����� �� ���� ��������");
        Console.WriteLine("4. ����� �� �����");
        Console.WriteLine("5. �����");

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
            Console.WriteLine("����� �������� �� ����������");
        }
    }
}
}
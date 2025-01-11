using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
class People
{
    public string Name { get; set; }
    public int Year { get; set; }
    public People(string name, int year)
    {
        Name = name;
        Year = year;
    }
    public virtual void PrintInfo()
    {
        Console.WriteLine($"���: {Name}, ��� ��������: {Year}");
    }
}
class Student : People
{
    public int[] Mark { get; set; }
    public Student(string name, int year, int[] mark) : base(name, year)
    {
        Mark = mark;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"������: {string.Join(", ", Mark)}");
    }
}
class Teacher : People
{
    public string[] Lesson { get; set; }
    public Teacher(string name, int year, string[] lesson) : base(name, year)
    {
        Lesson = lesson;
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"��������: {string.Join(", ", Lesson)}");
    }
}
class Program
{
    static void ZapolnStudent(Student[] student)
    {
        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine($"\n������� ��� �������� ��� ������� {i + 1}");
            string name = Console.ReadLine();

            Console.WriteLine("������� ��� �������� ��������");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("������� ���������� ������ ��������");
            int countMark = int.Parse(Console.ReadLine());
            var mark = new int[countMark];

            Console.WriteLine("������� ������ ��������");
            for (int j = 0; j < countMark; j++)
            {
                mark[j] = int.Parse(Console.ReadLine());
            }
            student[i] = new Student(name, year, mark);
        }
    }
    static void ZapolnTeacher(Teacher[] teacher)
    {
        for (int i = 0; i < teacher.Length; i++)
        {
            Console.WriteLine($"\n������� ��� ������������� ��� ������� {i + 1}");
            string name = Console.ReadLine();

            Console.WriteLine("������� ��� �������� �������������");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("������� ���������� ��������� �������������");
            int countSubject = int.Parse(Console.ReadLine());
            var subject = new string[countSubject];

            Console.WriteLine("������� ���������� �������������");
            for (int j = 0; j < countSubject; j++)
            {
                subject[j] = Console.ReadLine();
            }
            teacher[i] = new Teacher(name, year, subject);
        }
    }
    static void ViborYear(Student[] student)
    {
        Console.WriteLine("\n������� ��� �������� ��������");
        int year = int.Parse(Console.ReadLine());
        int kolvo = 0;

        for (int i = 0; i < student.Length; i++)
        {
            if (year == student[i].Year)
            {
                student[i].PrintInfo(); ;
                kolvo++;
            }
        }
        if (kolvo == 0)
        {
            Console.WriteLine("�������� �� �������");
        }
    }
    static void ViborSub(Teacher[] teacher)
    {
        Console.WriteLine("\n�������� ����������");
        string lesson = Console.ReadLine();
        int kolvo = 0;

        for (int i = 0; i < teacher.Length; i++)
        {
            foreach (var subj in teacher[i].Lesson)
            {
                if (subj.Equals(lesson))
                {
                    teacher[i].PrintInfo();
                    kolvo++;
                }
            }
        }
        if (kolvo == 0)
        {
            Console.WriteLine("������������� �� �������");
        }
    }
    public static void Main()
    {
        Console.WriteLine("������� ���������� ��������������");
        int countTeacher = int.Parse(Console.ReadLine());
        Teacher[] teacher = new Teacher[countTeacher];

        Console.WriteLine("������� ���������� ���������");
        int countStudent = int.Parse(Console.ReadLine());
        Student[] student = new Student[countStudent];

        bool a = true;
        while (a)
        {
            Console.WriteLine("\n" + "\t����");
            Console.WriteLine("1. ����������");
            Console.WriteLine("2. ������ ������");
            Console.WriteLine("3. ����� ��������� �� ���� ��������");
            Console.WriteLine("4. ����� �������������� �� ����������");
            Console.WriteLine("5. �����");

            int vibor = int.Parse(Console.ReadLine());

            if (vibor == 1)
            {
                Console.WriteLine("\n1. ��������� ������ ��������");
                Console.WriteLine("2. ��������� ������ �������������");

                int vibor2 = int.Parse(Console.ReadLine());

                if (vibor2 == 1)
                {
                    ZapolnStudent(student);
                }
                else if (vibor2 == 2)
                {
                    ZapolnTeacher(teacher);
                }
                else
                {
                    Console.WriteLine("����� �������� �� ����������");
                }
            }
            else if (vibor == 2)
            {
                Console.WriteLine("\n1. ������ ������ � ���������");
                Console.WriteLine("2. ������ ������ � ��������������");

                int vibor2 = int.Parse(Console.ReadLine());

                if (vibor2 == 1)
                {
                    Console.WriteLine("\n��������: ");
                    for (int i = 0; i < countStudent; i++)
                    {
                        student[i].PrintInfo();
                    }
                }
                else if (vibor2 == 2)
                {
                    Console.WriteLine("\n�������������: ");
                    for (int i = 0; i < countTeacher; i++)
                    {
                        teacher[i].PrintInfo();
                    }
                }
                else
                {
                    Console.WriteLine("����� �������� �� ����������");
                }
            }
            else if (vibor == 3)
            {
                ViborYear(student);
            }
            else if (vibor == 4)
            {
                ViborSub(teacher);
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
using System;
class Program
{
    static void Main()
    {
        int n, m, maxindex2 = 0, maxindex = 0;
        Console.WriteLine("������� ����������� �������: ");
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("������� ������: ");
        int[,] array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                array[i, k] = int.Parse(Console.ReadLine());
            }
        }
        int minimax = -10000000;
        for (int i = 0; i < n; i++)
        {
            int maxstrok = array[i, 0];
            for (int k = 1; k < m; k++)
            {
                if (array[i, k] > maxstrok)
                {
                    maxstrok = array[i, k];
                    maxindex = k;
                    maxindex2 = i;
                }
            }
            bool minstolb = true;
            for (int j = 0; j < n; j++)
            {
                if (array[j, maxindex] < maxstrok)
                {
                    minstolb = false;
                    break;
                }
            }
            if (minstolb)
            {
                maxindex2 = i;
                minimax = maxstrok;
                break;
            }
        }
        if (minimax > -10000000)
        {
            Console.WriteLine("��������: " + minimax);
            Console.WriteLine("������(x): " + (maxindex2 + 1));
            Console.WriteLine("�������(y): " + (maxindex + 1));
        }
        else
        {
            Console.WriteLine("��������� ���");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka, normik = "";
            stroka = Console.ReadLine();
            for (int i = 0; i < stroka.Length; i++)
            {
                if (i != 0 && stroka[i - 1] != stroka[i])
                {
                    normik += stroka[i - 1];

                }
                else if (i != 0 && stroka[i - 1] == stroka[i] && stroka[i - 1] != ' ')
                {
                    normik += stroka[i - 1];
                }
            }
            Console.WriteLine(normik);
            Console.ReadLine();
        }
    }
}
// убрать все лишние пробелы со строки //

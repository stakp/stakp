using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace максимальное_минимальное_число
{
    class Program
    {
        static void Main(string[] args)
        {
            Poisk.poisk();
        }
    }
    public static class Poisk
    {
        public static void poisk()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int max = 0, min = 0, nmax = 0, nmin = 0, flag = 0, flag1 = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
                if (flag == 0)
                {
                    flag += 1;
                    max = mas[i];
                    min = mas[i];
                    nmax = i;
                    nmin = i;
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                    nmin = i;
                }
                else if (mas[i] >= max)
                {
                    max = mas[i];
                    nmax = i;
                }

            }

            Console.WriteLine("Наибольшее число = {0}, его номер = {1}", max, nmax + 1);
            Console.WriteLine("Наименьшее чило равно = {0}, его номер = {1}", min, nmin + 1);
            Console.ReadLine();
        }


    }
}

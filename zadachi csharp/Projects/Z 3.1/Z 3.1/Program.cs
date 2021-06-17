using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Poisk.search();
        }
    }
    public static class Poisk
    {
        public static void search()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];
            double min = 0, max = 0, flag = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToDouble(Console.ReadLine());
                if (flag == 0)
                {
                    flag += 1;
                    min = mas[i];
                    max = mas[i];
                }

                if (mas[i] > max)
                {
                    max = mas[i];
                }
                else if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            Console.WriteLine("Наибольшее число = {0}", max);
            Console.WriteLine("наименьшее чило = {0}", min);
            Console.ReadLine();

        }
    }
}

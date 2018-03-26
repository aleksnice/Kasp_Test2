using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNum = new List<int>() { 2, 1, 2, 1, 0, 0, 2, 1, 1, 2, 1, 0 };
            List<int> lstNum1 = new List<int>() { 1, 2, 0, 0, 3, 2, 1, 1, 0, 2 };
            List<int> lstNum2 = new List<int>() { 2, 2, 1, 1, 4, 0, 2, 2 };
            int x = 2;
            int x1 = 3;
            int x2 = 4;

            Console.WriteLine("Первый расчет:");
            CountPairSums(lstNum, x);
            Console.WriteLine("Второй расчет:");
            CountPairSums(lstNum1, x1);
            Console.WriteLine("Третий расчет:");
            CountPairSums(lstNum2, x2);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод для вывода уникальных сочетаний
        /// </summary>
        /// <param name="list">коллекция чисел</param>
        /// <param name="x">заданное число</param>
        static void CountPairSums(List<int> list, int x)
        {
            int numFirst = 0;
            int numLast = list.Count - 1;
            list.Sort();
            while (numFirst < numLast)
            {
                int summa = list[numFirst] + list[numLast];
                if (summa == x)
                {
                    Console.WriteLine("(" + list[numFirst] + "," + list[numLast] + ")");
                    numFirst++;
                    numLast--;
                }
                else
                {
                    if (summa < x) numFirst++;
                    else numLast--;
                }
            }
        }
    }
}

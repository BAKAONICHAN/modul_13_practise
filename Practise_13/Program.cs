using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            ReadLine();
        }

        private static void Task2()
        {
            int mediumValue = 0;
            int countOfElements = 10;
            int choosenNumber = 0;
            WriteLine("Введите размер коллекции");
            while (!int.TryParse(ReadLine(), out countOfElements ))
            {
                Clear();
                Write("Ошибка, введите целое число: ");
            }
            WriteLine("Введите число до которого я буду рандомить");
            while (!int.TryParse(ReadLine(), out choosenNumber))
            {
                Clear();
                Write("Ошибка, введите целое число: ");
            }
            ArrayList arraylist = new ArrayList();
            Random rand = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                arraylist.Add(rand.Next(choosenNumber));
            }
            WriteLine("Первоначальный");
            foreach (int obj in arraylist)
            {
                Write(" {0}", obj);
            }
            WriteLine();
            for (int i = 0; i < arraylist.Count; i++)
            {
                mediumValue = mediumValue + (int)arraylist[i];
            }
            mediumValue = mediumValue / arraylist.Count;
            WriteLine("Второй");
            for (int i = 0; i < arraylist.Count; i++)
            {
               if((int)arraylist[i]>mediumValue)
                {
                    Write((int)arraylist[i]+" ");
                }
            }
            ReadLine();
        }
        #region First
        private static void Task1()
        {
            int countOfElements = 10;
            ArrayList arraylist = new ArrayList();
            Random rand = new Random();
            for (int i = 0; i < countOfElements; i++)
            {
                arraylist.Add(rand.Next(28));

            }
            WriteLine("Первоначальный");
            foreach (int obj in arraylist)
            {
                Write(" {0}", obj);

            }
            WriteLine();
            for (int i = 0; i < arraylist.Count; i++)
            {
                if ((int)arraylist[i] % 2 == 1)
                {
                    arraylist.RemoveAt(i);
                }
            }
            WriteLine("Второй");
            foreach (int obj in arraylist)
            { Write(" {0}", obj); }
            ReadLine();
        }
        #endregion
    }
}


    


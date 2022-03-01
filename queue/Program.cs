using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n, s;

            Queue myQ = new Queue();
            myQ.Enqueue(-2);
            myQ.Enqueue(-1);
            myQ.Enqueue(1);
            myQ.Enqueue(3);
            myQ.Enqueue(5);
            myQ.Enqueue(8);
            
            Console.WriteLine("Ввод S: ");
            myQ.Enqueue(s = Console.Read());
            Console.WriteLine(" ");
            
            Console.WriteLine("\tРазмер:    {0}", myQ.Count);
            n = myQ.Count;
            Console.Write("\tСписок:");
            PrintValues(myQ);
            // Почему то я когда ввожу S и пытаюсь его добавить в массив, его значение меняется на 50, поэтому программа не совсем корректно работает.
            Object[] array = myQ.ToArray();

            int min = (int)array.Min();
            int max = (int)array.Max();

            Console.Write("\tОтсортированный Список:");
            var result = array.OrderBy(t=>t);
            foreach (int t in result) Console.Write("    {0}", t);
            Console.Write(" ");


            var indexMin = Array.IndexOf(array, min);
            var indexMax = Array.IndexOf(array, max);
            var indexS = Array.IndexOf(array, s);
                if (indexS - indexMax < indexS - indexMin)
                    Console.WriteLine($"Индекс = {indexMin}, значение = {min}");
                if (indexS - indexMax > indexS - indexMin)
                    Console.WriteLine($"Index = {indexMax}, значение = {max}");

            




        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        
    }
}
 //15. Дан массив вещественных чисел. Определить элемент массива (значение и индекс), который наиболее удален от заданного вещественного числа S

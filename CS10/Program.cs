//Нужно написать программу (используя циклы, обязательно пояснить выбор вашего цикла), 
//чтобы она выводила следующую последовательность 5 12 19 26 33 40 47 54 61 68 75 82 89 96
//Нужны переменные для обозначения чисел в условии цикла.
using System;

namespace CS10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startСycle = 5;
            int endCycle = 103;
            int numberAdding = 7;

            for (int i = startСycle; i < endCycle; i += numberAdding)
            {
                Console.WriteLine(i);
            }
        }
    }
}

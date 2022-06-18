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
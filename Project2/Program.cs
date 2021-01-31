using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите набор чисел через пробел: ");
            string numbers = Console.ReadLine();
            string[] ns = numbers.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            for(int i=0; i<ns.Length;i++)
            {
                int n = Convert.ToInt32(ns[i]);
                sum += n;
            }

            Console.Write(sum);
        }
    }
}

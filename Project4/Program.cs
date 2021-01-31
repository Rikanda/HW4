using System;

namespace Project4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Укажите число: ");
            int n = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int n)
        {
           if(n<=0)
            {
                return 0;
            }

            if (n == 1)
            {
                return n;
            }

            return GetFibonacci(n - 1)+ GetFibonacci(n - 2);

        }
        



        
    }
}

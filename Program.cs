using System;

namespace Fact
{
    internal class Program
    {
        public static long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        static void Main(string[] args)
        {
            int num  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fact(num));
        }
    }
}

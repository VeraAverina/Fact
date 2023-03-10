using System;


namespace Fact
{
    public class Program
    {
        public static long Fact(long n)
        {
            if (n < 0)
                throw new Exception();
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

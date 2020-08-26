using System;

namespace Starting_with_MSTest
{
    public class Program
    {
        public static void take(ref int a, ref int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        public static int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {


            int a = 0;
            int b = 0;

            take(ref a, ref b);


            Console.WriteLine(add(a, b));


        }
    }
}

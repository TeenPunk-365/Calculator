using System;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string a;
            string b;
            string k;
                a = GetData("Input num1");
                k = Sign("Input sign: +,-,*,/");
                b = GetData("Input num2");
                double resultm = Solution.Minus(k,a, b, out string msgm);
                Console.WriteLine($"{msgm} {resultm}"); 
        }
        public static string GetData(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            return Console.ReadLine();
        }
        public static string Sign(string IM)
        {
            Console.WriteLine(IM);
            return Console.ReadLine();
        }
    }
}

using System;

namespace TravisCITest
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public static int Min(int num1, int num2)
        {
            return num1 - num2;
        }
        
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
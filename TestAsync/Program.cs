using System;
using System.Diagnostics.Tracing;
using System.Threading.Tasks;

namespace TestAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.ReadKey();
        }

        private static async void Print()
        {
            await FuncB();
            FuncA();
        }

        public static void FuncA()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("a");
            }
        }

        public static async void FuncB()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("b");
            }
        }
    }
}

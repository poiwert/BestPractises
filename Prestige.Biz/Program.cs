using System;

namespace Prestige.Biz
{
    internal class Program
    {
        public const int ConstantNumber = 99;
        public static readonly int ReadOnlyNumber;

        static Program()
        {
            ReadOnlyNumber = 5;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(ConstantNumber);
            //Console.WriteLine(ReadOnlyNumber);
            Agency agency = null;
            Console.WriteLine(agency?.AgencyName);

            // Keep the console window open until user interaction
            Console.ReadLine();
        }
    }
}

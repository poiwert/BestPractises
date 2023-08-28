using System;
using System.IO;

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
            //Agency agency = null;
            //Console.WriteLine(agency?.AgencyName);
            //FileStream fs1 = new FileStream(
            //    @"C:\source\repos\BestPractises\README.md", FileMode.Open);
            //FileStream fs2 = new FileStream(
            //    @"C:\source\repos\BestPractises\README.md", FileMode.Open);
            using (FileStream fs1 = new FileStream(
                @"C:\source\repos\BestPractises\README.md", FileMode.Open))
            {
                //Do smth
            }
            using (FileStream fs2 = new FileStream(
                 @"C:\source\repos\BestPractises\README.md", FileMode.Open))
            {
                //Do smth
            }
            // Keep the console window open until user interaction
            Console.ReadLine();
        }
    }
}

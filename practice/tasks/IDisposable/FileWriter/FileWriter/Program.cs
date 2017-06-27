using System;

namespace Convestudo.Unmanaged
{
    class Program
    {
        private static void Main(string[] args)
        {

            using (var fileWriter = new FileWriter("c:\\logs\\log.txt"))
            {
                fileWriter.Write("First test string");
            }
            Console.WriteLine("finish");

            Console.ReadKey();
        }
    }
}

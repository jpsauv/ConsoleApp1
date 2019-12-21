using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[0];

            try
            {
                lines = File.ReadAllLines(@"C:\Users\James Sauve\Desktop\Creed.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("The file was not found or there was another error.");
            }

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}



using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] origin = new string[0];
            string[] changed = new string[0];

            try
            {
                origin = File.ReadAllLines(@"C:\Users\James Sauve\Desktop\Creed.txt");
                changed = File.ReadAllLines(@"C:\Users\James Sauve\Desktop\Creeda.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Either the file was not found or there was another error.");
            }

            for (int i = 0; i < origin.Length; i++)
            {
                string line = origin[i];





            }
        }
    }
}



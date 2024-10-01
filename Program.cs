using System;
using System.IO;

namespace KASDLab05
{
    internal class Program
    {
        static void Main()
        {
            string[] data = File.ReadAllLines("../../Data/input.txt");

            HTMLParser parser = new HTMLParser();

            MyArrayList<string> result = parser.Parse(data);

            result.Print();

            Console.ReadKey();
        }
    }
}

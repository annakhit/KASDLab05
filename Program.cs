using System;

namespace KASDLab05
{
    internal class Program
    {
        static void Main()
        {
            string[] data = FileReader.ReadOneDimensionalArray("../../Data/input.txt", value => value);

            HTMLParser parser = new HTMLParser();

            MyArrayList<string> result = parser.Parse(data);

            result.Print();

            Console.ReadKey();
        }
    }
}

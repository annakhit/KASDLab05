using System;
using System.IO;
using System.Linq;

public static class FileReader
{
    public static T[] ReadOneDimensionalArray<T>(string filePath, Func<string, T> parser)
    {
        string[] lines = File.ReadAllLines(filePath);
        return lines.Select(parser).ToArray();
    }
}
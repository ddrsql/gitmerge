using System;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var str = StringStringBuilder();
        Console.WriteLine(str);
    }

    private static StringBuilder StringStringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("User1");
        stringBuilder.Append("StringBuilder");
        return stringBuilder;
    }
}

using System;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var str = StringStringBuilder();
        str.Append("-OK");
        Console.WriteLine(str);
    }

    private static StringBuilder StringStringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("User1");
        stringBuilder.Append("-");
        stringBuilder.Append("StringBuilder");
        return stringBuilder;
    }
}

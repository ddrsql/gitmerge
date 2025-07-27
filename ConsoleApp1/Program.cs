using System;
using System.Text;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("User3-CW");
        Console.WriteLine("Hello, World!");
        var str = StringStringBuilder();
        str.Append("User2-Json");
        Test(str.ToString());
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

    private static void Test(string description)
    {
        var str = JsonSerializer.Serialize(new
        {
            Name = "Test-User2-Json",
            Description = description
        });
        Console.WriteLine(str);
    }
}

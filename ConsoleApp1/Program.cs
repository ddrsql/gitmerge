using System;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var str = string.Empty;
        Test(str.ToString());
        Console.WriteLine(str);
    }

    private static void Test(string description)
    {
        var str = JsonSerializer.Serialize(new
        {
            Name = "Test",
            Description = description
        });
        Console.WriteLine(str);
    }
}

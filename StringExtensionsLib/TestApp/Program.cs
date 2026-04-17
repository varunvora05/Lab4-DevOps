using System;
using StringExtensionsLib;

class Program
{
    static void Main()
    {
        string input1 = "Hello";
        string input2 = "hello";

        Console.WriteLine($"Input: {input1}");
        Console.WriteLine($"Starts with uppercase: {input1.StartsWithUpper()}");

        Console.WriteLine();

        Console.WriteLine($"Input: {input2}");
        Console.WriteLine($"Starts with uppercase: {input2.StartsWithUpper()}");
    }
}
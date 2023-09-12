using System;
using Microsoft.Maui.Storage;

namespace EssentialsApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"AppData folder: {FileSystem.AppDataDirectory}");
    }
}
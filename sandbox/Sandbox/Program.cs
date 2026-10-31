using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Sandbox Mundo!");
        Console.WriteLine("Isso é C#!");

        Console.Write("Qual é a sua cor favorita? ");
        string cor = Console.ReadLine();
        Console.WriteLine($"Sua cor favorita é {cor}");
    }
}
using System;
static class MathHelper
{   
    // Static Class with Static Member and Static Method.
    public static double Pi = 3.14159;

    public static int Square(int x) => x * x;
}

class Greeter
{
    // Static Method.
    public static void SayHello(string name) => Console.WriteLine($"Hello {name}!");
}

class Counter
{
    // Static Member
    public static int Count = 0;

    // Constructer.
    public Counter()
    {
        Count++; // Increase for all Instance.
    }

}

class Config
{
    public static string Setting;

    static Config()
    {
        Setting = "Initialized only once!";
        Console.WriteLine("Static Constructor Called.");
    } 
}

class Program
{
    static void Main()
    {
        // For Class MathHelper.
        Console.WriteLine(MathHelper.Pi);          // 3.14159
        Console.WriteLine(MathHelper.Square(5));   // 25

        // For Class Greeter.
        Greeter.SayHello("Anas");

        // For class Counter
        new Counter();
        new Counter();
        new Counter();
        new Counter();
        Console.WriteLine(Counter.Count);  // 4 (shared, not per object)

        // Usage
        // For Class Config
        Console.WriteLine(Config.Setting);

    }
}

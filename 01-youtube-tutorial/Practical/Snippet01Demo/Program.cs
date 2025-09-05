// This is a simple code for demonstrating static method call.
// This is a Comment
/* This is also a comment */
// static void SayHello(string name)
// {
//     Console.WriteLine($"Hello {name}!");
// }
// SayHello("Anas");
// SayHello("Saad");


// // Example:
// string fruit = "Apple";
// Console.WriteLine($"I like {fruit}");
// // Output: I like Apple


// // Taking Input from Console
// static void SayHelloByConsole(string name)
// {
//     Console.WriteLine($"Hello {name}!");
// }
// SayHelloByConsole(Console.ReadLine());


using System;
class Greeter
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }
}
class Program
{
    static void Main()
    {
        var g = new Greeter();
        g.SayHello("Anas");
        g.SayHello("Saad");
    }
}
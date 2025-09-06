// var myString = "string value";
// var myNumber = 123;


// var x = 10;   // x is int
// x = "hello"; ❌ error: cannot assign string to int


// when the type is obvious from the right-hand side:
// var name = "Anas";  // clearly a string
// var count = 5;      // clearly an int


// when the type is long or complex (like LINQ queries or generics):
// var result = customers.Where(c => c.Age > 18);

// ❌ avoid when it makes code less clear:
// var x = DoSomething(); // unclear what type x is!

// We can also write like this:
// string myString = "string value";
// int myNumber = 123;

using System;

class Program
{
    static void Main()
    {
        var myString = "String Value";
        var myInteger = 123;

        Console.WriteLine($"Value of String = {myString}");
        Console.WriteLine($"Value of Integer = {myInteger}");

        // Explicit typing for Comparison
        string explicitSting = "another String";
        int explicitInteger = 456;

        Console.WriteLine($"Value of Explicit String = {explicitSting}");
        Console.WriteLine($"Value of Explicit Integer = {explicitInteger}");

        // Dynamic type for Comparison 
        dynamic justcheckingString = "Dynamic Value!";
        Console.WriteLine($"Value of Dynamic String = {justcheckingString}");

    }
}
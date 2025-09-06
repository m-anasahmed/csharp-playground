// string myString = "value";
// int myNumber = 123;
// float myFloat = 666.66F;
// DateTime someDate = DateTime.Now;


// Float Condition
// float f = 3.14F;  // correct
// float g = 3.14;   // ❌ error (3.14 is a double by default)

// Printing Date after 7 days
// DateTime deadline = DateTime.Now.AddDays(7);
// Console.WriteLine(deadline);

using System;

class Program
{
    static void Main()
    {
        string myString = "value";
        int myNumber = 123;
        float myFloat = 666.66F;
        DateTime someDate = DateTime.Now;

        Console.WriteLine($"String: {myString}");
        Console.WriteLine($"Number: {myNumber}");
        Console.WriteLine($"Float: {myFloat}");
        Console.WriteLine($"Date: {someDate}");
    }
}

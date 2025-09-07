// Snippet Code
// public class MyClass
// {
//     public string ValueA { get; }

//     public MyClass(string valueA)
//     {
//         ValueA = valueA;
//     }

//     public void Deconstruct(out string valueA)
//     {
//         valueA = this.ValueA;
//     }
// }

// Example
// var obj = new MyClass("Hello");

// Example
// var obj = new MyClass("World");
// var (val) = obj;   // calls Deconstruct
// Console.WriteLine(val); // World

// Main Program
public class Person
{
    public string Name { get; }
    public int Age { get; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Deconstructor
    public void Deconstruct(out string name, out int age)
    {
        name = this.Name;
        age = this.Age;
    }
}
class Program
{
    static void Main()
    {
        var p = new Person("Anas", 22);

        // normal access
        Console.WriteLine($"{p.Name}, {p.Age}");

        // deconstruction
        var (n, a) = p;
        Console.WriteLine($"{n}, {a}");
    }
}

// Example
// public record User(string Name, int Age);
// var u = new User("Ali", 30);
// var (n, a) = u;  // works out of the box

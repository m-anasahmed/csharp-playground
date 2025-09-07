// Snippet10
// public class MyClass
// {
//     public string MyProperty { get; set; }
//     public int OtherProperty { get; set; }
// }

// Example of Logic:
// private int age; // Variable
// public int Age // function
// {
//     get { return age; }
//     set
//     {
//         if (value >= 0) age = value;
//         else throw new ArgumentException("Age must be positive and greater than zero");
//     }
// }

// One line Example:
// public string MyProperty { get; set; }

// Example
// public string Name { get; private set; }

// Example
// public string Country { get; set; } = "Pakistan";

// Example
// public string Id { get; } = Guid.NewGuid().ToString();

// Example
// public int DoubleAge => Age * 2;


// Practical Example:
class Program
{
    static void Main()
    {
        var person = new Person("Anas", 22);

        Console.WriteLine(person.Name); // Anas
        //person.Age = 30; // ❌ not allowed (private setter)
        Console.WriteLine(person.Age); // Anas

        person.Name = "Ali"; // ✅ allowed
        Console.WriteLine(person.Name); // Ali
    }
}

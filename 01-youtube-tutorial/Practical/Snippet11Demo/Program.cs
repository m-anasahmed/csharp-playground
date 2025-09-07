// Snippet 11
// public class MyClass
// {
//     public string MyProperty { get; set; }

//     private int _otherProperty;
//     public int OtherProperty
//     {
//         get { return _otherProperty; }
//         set { _otherProperty = value; }
//     }
// }

// Example:
// obj.OtherProperty = 10; 
// inside setter → value = 10

//Example
// public string FullName => $"{FirstName} {LastName}";

//Example
// public int MyProperty { get; set; }

// Practice main code
public class Person
{
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0) throw new ArgumentException("Age cannot be negative");
            _age = value;
        }
    }
}
class Program
{
    static void Main()
    {
        var p = new Person();
        p.Age = 25;  // ✅ works
        Console.WriteLine(p.Age); // 25
        //p.Age = -5;  // ❌ throws exception

    }
}

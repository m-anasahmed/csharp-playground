// Snippet 05 => Access Modifiers
// public class MyClass
// private
// protected
// internal
// file

// // Example for Public Access Modifiers
// public class Car
// {
//     public void Drive() => Console.WriteLine("Driving");
// }
// class Program
// {
//     static void Main()
//     {
//         var action = new Car();
//         action.Drive();
//     }
// }

// Example for Private Access Modifiers
// class Engine
// {
//     private void Ignite() => Console.WriteLine("Ignited");

//     public void InClassCall()
//     {
//         // ✅ Allowed: private method can be called inside the same class
//         Ignite();
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Engine engine = new Engine();
//         // engine.Ignite(); ❌ // Not allowed, because Ignite() is private
//         // ✅ Allowed, calls private Ignite() internally
//         engine.InClassCall();
//     }
// }

// Example for Protected Access Modifiers
// public class MyClass
// {
//     protected void MyMethod() => Console.WriteLine("Hello, I am from Protected method.");
// }
// public class Child : MyClass
// {
//     public void Call() => MyMethod(); // ✅ allowed
// }
// class Program
// {
//     static void Main()
//     {
//         Child child = new Child();
//         child.Call();
//     }
// }

// Example for Internal Access Modifiers
// internal class Helper { }

// Example for file Access Modifiers
// file class FileScopedHelper { }

using System;

public class MyClass
{
    public void PublicMethod() => Console.WriteLine("Public");
    private void PrivateMethod() => Console.WriteLine("Private");
    protected void ProtectedMethod() => Console.WriteLine("Protected");
    internal void InternalMethod() => Console.WriteLine("Internal");

    // Only work in C# (11+)
    // file class FileHelper { public void Print() => Console.WriteLine("File Scoped"); }

    public void InClassCallProtectedMethod()
    {
        ProtectedMethod();
    }
}
class Child : MyClass
{
    public void Test()
    {
        // this.PrivateMethod();   // ❌ not allowed
        this.ProtectedMethod();    // ✅ allowed in derived class
    }
}
class Program
{
    static void Main()
    {
        var obj = new MyClass();
        obj.PublicMethod();    // ✅ allowed
        obj.InternalMethod();  // ✅ allowed (same assembly)
        obj.InClassCallProtectedMethod(); // Calling from within class
        // obj.ProtectedMethod(); // ❌ not allowed
        // obj.PrivateMethod();   // ❌ not allowed
    }
}

// Snippet Code:
// public class MyClass
// {
//     protected void MyMethod()
//     {
//         Console.WriteLine("Hello");
//     }
// }

class Program
{
    static void Main()
    {
        var child = new ChildClass();
        child.CallParentMethod(); // ✅ works
        // child.MyMethod();      // ❌ Error: not accessible outside class hierarchy
    }
}

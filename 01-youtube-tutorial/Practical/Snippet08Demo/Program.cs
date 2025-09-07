// Snippet 08
// public abstract class BaseClass
// {
//     public abstract void MyMethod();
// }

// public class MyClass : BaseClass
// {
//     public override void MyMethod()
//     {
//         Console.WriteLine("Hello");
//     }
// }

// Example Code.
// public abstract class Animal
// {
//     public abstract void Speak(); // must be implemented
// }

// public class MyClass : BaseClass
// {
//     public override void MyMethod()
//     {
//         Console.WriteLine("Hello");
//     }
// }

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a circle");
}

public class Square : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a square");
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Square();

        shape1.Draw();  // Drawing a circle
        shape2.Draw();  // Drawing a square
    }
}

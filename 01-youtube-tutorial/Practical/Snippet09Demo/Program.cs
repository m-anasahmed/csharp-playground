// public interface IMyInterface
// {
//     void MyMethod();
// }

// public class MyClass : IMyInterface
// {
//     public void MyMethod()
//     {
//         Console.WriteLine("Hello");
//     }
// }

// Example in one line:
// public class Car : IDriveable, IRepairable { ... }

// Example in one line:
// Printer printer = new Printer();

// Example in one line:
// IPrinter printer = new ConsolePrinter();

// Main Code:
public interface IShape
{
    void Draw();
}
public class Circle : IShape
{
    public void Draw() => Console.WriteLine("Drawing a Circle");
}
public class Square : IShape
{
    public void Draw() => Console.WriteLine("Drawing a Square");
}
class Program
{
    static void Main()
    {
        IShape shape1 = new Circle();
        IShape shape2 = new Square();

        shape1.Draw();  // Drawing a Circle
        shape2.Draw();  // Drawing a Square
    }
}


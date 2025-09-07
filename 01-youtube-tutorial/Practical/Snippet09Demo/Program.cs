public interface IMyInterface
{
    void MyMethod();
}

public class MyClass : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("Hello");
    }
}

public class ChildClass : MyClass
{
    public void CallParentMethod()
    {
        MyMethod(); // ✅ allowed (inherited)
    }
}

//Snippet06
// public class MyClass
// {
//     protected void MyMethod()
//     {
//         Console.WriteLine("Hello");
//     }
// }


// 01
// public class Car
// {
//     public string Model;
//     public void Drive() => Console.WriteLine($"{Model} is driving");
// }
// class Program
// {
//     static void Main()
//     {
//         var car = new Car { Model = "Honda" };
//         car.Drive();  // Honda is driving

//     }
// }


// 02
// public class Animal { public void Eat() => Console.WriteLine("Eating"); }
// public class Dog : Animal { public void Bark() => Console.WriteLine("Bark"); }

// class Program
// {
//     static void Main()
//     {
//         var dog = new Dog();
//         dog.Bark();
//         dog.Eat();
//     }
// }


//03
// interface IMovable { void Move(); }
// public class Car : IMovable { public void Move() => Console.WriteLine("Car moves"); }
// class Program
// {
//     static void Main()
//     {
//         // 1. Call via class reference => Class reference (Car)
//         Car car = new Car();
//         car.Move();

//         // 2. Call via interface reference => Interface reference (IMovable)
//         IMovable moveable = new Car();
//         moveable.Move();
//     }
// }

// 04
// class Person
// {
//     // Variable
//     public string Name;
//     // Constructor
//     public Person(string name)
//     {
//         Name = name;
//     } 
// }
// class Program
// {
//     static void Main()
//     {
//         var p = new Person("Anas");
//         Console.WriteLine(p.Name);
//     }
// }

//05
// class Animal { public virtual void Speak() => Console.WriteLine("This is original me."); }
// class Dog : Animal { public override void Speak() => Console.WriteLine("I override the context of this method."); }
// class Program
// {
//     static void Main()
//     {
//         Animal animal = new Animal();
//         animal.Speak();

//         Dog dog = new Dog();
//         dog.Speak();
//     }
// }

using System;

class Program
{
    static void Main()
    {
        var introduce = new Student { name = "Anas", age = 21 };
        introduce.Introduce();
    }
}
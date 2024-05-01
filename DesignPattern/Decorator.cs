namespace DemoTestApp;


// The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects dynamically,
// without affecting the behavior of other objects from the same class. In C#, you can implement the Decorator Pattern using interfaces and inheritance.


// Interface is a magiical component in OOPS 

//Manin interface
public interface IComponent
{
    string Operation();
}


// Main Class
public class Component : IComponent
{
    public string Operation()
    {
        return "Concrete Component operation";
    }
}

// I don't want to change the behavior or the Component class, I create a Decorator  Interface
public interface  IDecorator : IComponent
{
    public void Decorate();
}

public class Decorator_A : IDecorator
{
    public string Operation()
    {
        return "Decorator A operation";
    }

    public void Decorate()
    {
        Console.WriteLine("Decorate Class A");
    }
}

public class Decorator_B : IDecorator
{
    public string Operation()
    {
        return "Decorator B operation";
    }

    public void Decorate()
    {
        Console.WriteLine("Decorate Class B");
    }
}





namespace DemoTestApp;

public interface ICar
{
    string GetCarType();
}

public class Sedan : ICar
{
    public string GetCarType()
    {
        return "This is a Sedan";
    }
}

public class SUV : ICar
{
    public string GetCarType()
    {
        return "This is a SUV";
    }
}

public class HatchBack : ICar
{
    public string GetCarType()
    {
        return "This is a HatchBack";
    }
}


//Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
//but allows subclasses to alter the type of objects that will be created.

public interface IFactory
{
    ICar GetCarInstance(string type);
}

public class Factory : IFactory
{
    public ICar GetCarInstance(string type)
    {
        if (string.IsNullOrEmpty(type))
        {
            throw new ArgumentNullException(nameof(type));
        }

        return type switch
        {
            "Sedan" => new Sedan(),
            "SUV" => new SUV(),
            _ => new HatchBack()
        };
    }
}

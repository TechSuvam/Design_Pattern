namespace DemoTestApp
{
    public interface ITarget
    {
        void Request();
    }

    public class Target: ITarget
    {
        public void Request()
        {
            Console.WriteLine("Target: The request is being handled");
        }
    }
    // Now, suppose we have a third-party class with a different interface that we want to use within our system:
    public class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("Adaptee: Specific request is being handled");
        }
    }

    //We can create an adapter class that implements the ITarget interface and internally uses an instance of the Adaptee class to fulfill the request:
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}

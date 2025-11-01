namespace DesignPattern
{
    public interface ITarget
    {
        void Request();
    }

    public class Target : ITarget
    {   
        public void Request()
        {
            Console.WriteLine("Target: The request is being handled");
        }
    }

    public class Adaptee
    {
        public void SpecialRequest()
        {
            Console.WriteLine("Adaptee: Specific request is being handled");
        }
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee ?? throw new ArgumentNullException(nameof(adaptee));
        }

        public void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}

namespace DesignPattern
{
    //This is facade class
    public class Facade
    {
        private readonly ISubsystem_One subsystem_One;
        private readonly ISubsystem_Two subsystem_Two;

        public Facade(ISubsystem_One subsystem_One, ISubsystem_Two subsystem_Two)
        {
            this.subsystem_One = subsystem_One;
            this.subsystem_Two = subsystem_Two;
        }

        public void FacadeDesign()
        {
            var one_object_system = this.subsystem_One.GetSubSystem();
            Console.WriteLine(one_object_system);
            var two_object_System = this.subsystem_Two.GetSubSystem();
            Console.WriteLine(two_object_System);
        }
    }

    public interface ISubsystem_One
    {
        public string GetSubSystem();
    }

    public interface ISubsystem_Two
    {
        public int GetSubSystem();
    }

    public class Subsystem_One : ISubsystem_One
    {
        public string GetSubSystem()
        {
            return "Subsyatem_One";
        }
    }

    public class Subsystem_Two : ISubsystem_Two
    {
        public int GetSubSystem()
        {
           return 2;
        }
    }
}

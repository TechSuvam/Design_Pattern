namespace DemoTestApp;

//We make it as a sealed class ensure that no class can inherit the class
public sealed class Singleton
{
	private static Singleton instance;	

	// Make sure unable to create any instance from outside the class
	private Singleton()
	{

	}
	// Public prop is responsible to 
	public static Singleton SingletonProp {
		get
		{
			return instance ?? new Singleton();
		}
	}

	public string GetClassName()
	{
		return "This is a singleton class";
	}
}


namespace DemoTestApp;

public abstract class Vehicle
{
	private readonly ICarType _carType;
	public Vehicle(ICarType carType)
	{
		_carType = carType;
	}

	public void GetCars()
	{
		string[] cars = _carType.GetSUVCars();
	}

	public abstract bool IsValidDriver(int age);
}

public interface ICarType
{
	string[] GetSUVCars();
}

public class Tata : ICarType
{
	public string[] GetSUVCars()
	{
		return new string[] { "Tata Punch", "Tata Safari" };
	}
}

public class Mahindra : ICarType
{
    public string[] GetSUVCars()
    {
        return new string[] { "Mahindra Scrorpio", "Mahindra XUV3OO" };
    }
}


public class Bridge : Vehicle
{

	public Bridge(ICarType carType) : base(carType)
	{

	}
	public override bool IsValidDriver(int age)
	{
		return age >= 18;
	}
}


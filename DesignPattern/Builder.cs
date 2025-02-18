namespace DesignPattern
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
    }
    public class Builder
    {
        private readonly Computer computer = new();

        public Builder AddCpu(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public Builder AddRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }

        public Builder AddHardDisk(string hardDisk)
        {
            computer.HardDisk = hardDisk;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }

    }



    public class Car
    {
        public string  EngineType { get; set; }
        public string CarType { get; set; }

        public string FuelType { get; set; }
    }

    public class CarBuilder
    {
        private readonly Car car = new();

        public CarBuilder AddEngine(string engine)
        {
            car.EngineType = engine;
            return this;
        }

        public CarBuilder AddCar(string car)
        {
            this.car.CarType = car;
            return this;
        }

        public CarBuilder AddFuelType(string fuelType)
        {
            car.FuelType = fuelType;
            return this;
        }

        public Car Build() { 
            return car;
        }
    }
}

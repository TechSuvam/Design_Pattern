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
}

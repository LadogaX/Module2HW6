namespace Module2HW6.Abstractions
{
    public abstract class ElectricalAppliance : IElectricalAppliance
    {
        public abstract string Name { get; set; }
        public abstract int Voltage { get; set; }

        public abstract int Power { get; set; }
    }
}

namespace Module2HW6.Abstractions
{
    public interface IElectricalAppliance
    {
        string Name { get; set; }
        int Power { get; set; }
        int Voltage { get; set; }
    }
}
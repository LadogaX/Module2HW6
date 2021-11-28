using Module2HW6.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface IListElectrical
    {
        public IElectricalAppliance[] ElectricalAppliances { get; set; }
    }
}

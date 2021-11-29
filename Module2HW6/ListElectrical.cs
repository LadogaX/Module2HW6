using Module2HW6.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class ListElectrical : IListElectrical
    {
        public IElectricalAppliance[] ElectricalAppliances { get; set; }
    }
}

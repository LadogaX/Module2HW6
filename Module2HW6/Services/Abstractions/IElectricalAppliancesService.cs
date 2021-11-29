using System.Collections.Generic;
using Module2HW6.Abstractions;

namespace Module2HW6.Services.Abstractions
{
    public interface IElectricalAppliancesService
    {
        int CountElectricalAppliancesApartments { get; set; }
        void Add(IElectricalAppliance electricalAppliance);

        void SetCapacity(int capacity);

        void DisplayListApplines();

        void DisplayListApplines(IElectricalAppliance[] electricalAppliances);

        string DisplayElectricalAppliance(IElectricalAppliance electricalAppliance);

        IListElectrical GeListElectrical();

        void Sort(IComparer<IElectricalAppliance> comparer);

        int GetSumUseingPower();

        int GetSumUseingPower(IElectricalAppliance[] electricalAppliances);
    }
}

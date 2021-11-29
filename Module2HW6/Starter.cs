using System;
using Module2HW6.Abstractions;
using Module2HW6.Helpers;
using Module2HW6.Services.Abstractions;
using Module2HW6.Services.Comparators;

namespace Module2HW6
{
    public class Starter
    {
        private readonly IElectricalAppliancesService _electricalAppliancesService;
        public Starter(IElectricalAppliancesService electricalAppliancesService)
        {
            _electricalAppliancesService = electricalAppliancesService;
        }

        public void Run()
        {
            AddingElectricalApplineceInAppatments();
            _electricalAppliancesService.Sort(new ElectricalPowerComparator());
            _electricalAppliancesService.DisplayListApplines();

            Console.WriteLine($"Summary power = {_electricalAppliancesService.GetSumUseingPower()}W");
            Console.WriteLine();

            var result = _electricalAppliancesService.GeListElectrical().FindAnimalForName(10, 800);
            if (result.Status)
            {
                Console.WriteLine(result.Message);
                _electricalAppliancesService.DisplayListApplines(result.ElectricalAppliances);
                Console.WriteLine($"Summary power = {_electricalAppliancesService.GetSumUseingPower(result.ElectricalAppliances)}W");
            }
        }

        public void AddingElectricalApplineceInAppatments()
        {
            _electricalAppliancesService.Add(new Washer());
            _electricalAppliancesService.Add(new VacuumCleaner());
            _electricalAppliancesService.Add(new Phone());
            _electricalAppliancesService.Add(new Microwave());
            _electricalAppliancesService.Add(new Freezer());
            _electricalAppliancesService.Add(new Computer());
            _electricalAppliancesService.Add(new ElectricStove());
            _electricalAppliancesService.Add(new Fridge());
        }
    }
}

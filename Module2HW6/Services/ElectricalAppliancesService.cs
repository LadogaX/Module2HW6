using System;
using System.Collections.Generic;
using Module2HW6.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class ElectricalAppliancesService : IElectricalAppliancesService
    {
        private readonly int _stepCapacity = 5;
        private IElectricalAppliance[] _electricalAppliances;
        private int _capacity;
        private IListElectrical _listElectrical;
        public ElectricalAppliancesService(IListElectrical listElectrical)
        {
            _listElectrical = listElectrical;
            _capacity = _stepCapacity;
            _electricalAppliances = new IElectricalAppliance[_capacity];

            _listElectrical.ElectricalAppliances = _electricalAppliances;
        }

        public int CountElectricalAppliancesApartments { get; set; }

        public void Add(IElectricalAppliance electricalAppliance)
        {
            if (CountElectricalAppliancesApartments == _electricalAppliances.Length)
            {
                _capacity += _stepCapacity;
                SetCapacity(_capacity);
            }

            for (var i = CountElectricalAppliancesApartments; i < _electricalAppliances.Length; i++)
            {
                if (_electricalAppliances[i] == null)
                {
                    _electricalAppliances[i] = electricalAppliance;

                    CountElectricalAppliancesApartments++;
                    break;
                }
            }
        }

        public void SetCapacity(int capacity)
        {
            if (_electricalAppliances.Length >= CountElectricalAppliancesApartments)
            {
                Array.Resize(ref _electricalAppliances, capacity);
                _listElectrical.ElectricalAppliances = _electricalAppliances;
            }
        }

        public void DisplayListApplines()
        {
            Console.WriteLine();
            Console.WriteLine("Devices connected to the socket:");
            DisplayListApplines(_electricalAppliances);
        }

        public void DisplayListApplines(IElectricalAppliance[] electricalAppliances)
        {
            for (var i = 0; i < electricalAppliances.Length; i++)
            {
                IElectricalAppliance electricalAppliancel = electricalAppliances[i];
                if (electricalAppliancel != null)
                {
                    Console.WriteLine(DisplayElectricalAppliance(electricalAppliancel));
                }
            }

            Console.WriteLine();
        }

        public string DisplayElectricalAppliance(IElectricalAppliance electricalAppliance)
        {
            return $"Product: {electricalAppliance.Name.PadRight(25)} Power {electricalAppliance.Power}";
        }

        public IListElectrical GeListElectrical()
        {
            return _listElectrical;
        }

        public void Sort(IComparer<IElectricalAppliance> comparer)
        {
            SetCapacity(CountElectricalAppliancesApartments);
            Array.Sort(_electricalAppliances, comparer);
        }

        public int GetSumUseingPower()
        {
            return GetSumUseingPower(_electricalAppliances);
        }

        public int GetSumUseingPower(IElectricalAppliance[] electricalAppliances)
        {
            int sumPower = 0;

            foreach (var electricalAppliance in electricalAppliances)
            {
                if (electricalAppliance != null)
                {
                    sumPower += electricalAppliance.Power;
                }
            }

            return sumPower;
        }
    }
}

using System.Collections.Generic;
using Module2HW6.Abstractions;

namespace Module2HW6.Services.Comparators
{
        public class ElectricalPowerComparator : IComparer<IElectricalAppliance>
        {
            public int Compare(IElectricalAppliance electricalAppliance1, IElectricalAppliance electricalAppliance2)
            {
                if (electricalAppliance1.Power > electricalAppliance2.Power)
                {
                    return 1;
                }
                else if (electricalAppliance1.Power < electricalAppliance2.Power)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
 }

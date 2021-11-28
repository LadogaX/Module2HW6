using System;
using Module2HW6.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Helpers
{
    public static class FindForPower
    {
        public static Result FindAnimalForName(this IListElectrical listElectrical, int lowerPower, int hightPower)
        {
            IElectricalAppliance[] electricalAppliances = listElectrical.ElectricalAppliances;
            IElectricalAppliance[] findingElectricalAppliance = new IElectricalAppliance[electricalAppliances.Length];
            var j = 0;

            for (var i = 0; i < electricalAppliances.Length; i++)
            {
                if (electricalAppliances[i].Power >= lowerPower && electricalAppliances[i].Power <= hightPower)
                {
                    findingElectricalAppliance[j++] = electricalAppliances[i];
                }
            }

            var countFinding = j;
            if (countFinding < electricalAppliances.Length)
            {
                Array.Resize(ref findingElectricalAppliance, countFinding);
            }

            return new Result
            {
                Status = countFinding > 0,
                Message = countFinding > 0 ? $"Found {countFinding} electrical appliance(s) for {lowerPower} - {hightPower}" : $"electrical appliance(s) for {lowerPower} - {hightPower} is not found",
                ElectricalAppliances = findingElectricalAppliance
            };
        }
    }
}

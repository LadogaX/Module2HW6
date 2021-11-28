using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public class Freezer : Storage
    {
        public override string Name { get; set; } = "ElectroLux V3";
        public override int Voltage { get; set; } = 220;
        public override int Power { get; set; } = 800;

        public int MaximumCoolingTemperature { get; set; } = -15;
    }
}

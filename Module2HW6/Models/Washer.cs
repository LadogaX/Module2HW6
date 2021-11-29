using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public class Washer : Cleaning
    {
        public override string Name { get; set; } = "ElectroLux V2021";
        public override int Voltage { get; set; } = 220;
        public override int Power { get; set; } = 1800;

        public bool IsUseWater { get; set; } = true;
    }
}

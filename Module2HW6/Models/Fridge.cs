using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public class Fridge : Storage
    {
        public override string Name { get; set; } = "Bocsh V1";
        public override int Voltage { get; set; } = 220;
        public override int Power { get; set; } = 900;

        public int MaximumCoolingTemperature { get; set; } = 4;
    }
}

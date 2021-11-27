using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class Microwave : CookingTechnique
    {
        public override string Name { get; set; } = "Microwave Cook";
        public override int Voltage { get; set; } = 220;
        public override int Power { get; set; } = 850;

        public bool UsingMicroxawes { get; set; } = true;
    }
}

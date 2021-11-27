using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public abstract class ElectricalAppliances
    {
        public abstract string Name { get; set; }
        public abstract int Voltage { get; set; }

        public abstract int Power { get; set; }
    }
}

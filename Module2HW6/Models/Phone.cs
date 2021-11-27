using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class Phone : Computers
    {
        public override string Name { get; set; } = "Sumsung A72";
        public override int Voltage { get; set; } = 5;
        public override int Power { get; set; } = 10;

        public bool IsMobileDevice { get; set; } = true;
    }
}

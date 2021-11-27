using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class Computer : Computers
    {
        public override string Name { get; set; } = "ASUS T77";
        public override int Voltage { get; set; } = 220;

        public override int Power { get; set; } = 550;

        public bool IsGraphicStation { get; set; } = true;
    }
}

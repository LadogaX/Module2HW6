using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public abstract class Electronics : ElectricalAppliance
    {
        public ApplicationArea ApplicationArea { get; set; } = ApplicationArea.ConsumerElectronics;
    }
}

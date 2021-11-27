using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
   public abstract class KitchenAppliances : ElectricalAppliances
    {
        public ApplicationArea ApplicationArea { get; set; } = ApplicationArea.Kitchen;
    }
}

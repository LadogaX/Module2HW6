﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public abstract class Cleaning : Electronics
    {
        public bool IsCleaning { get; set; } = true;
    }
}

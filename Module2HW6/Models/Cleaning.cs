﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Abstractions
{
    public abstract class Cleaning : Electronics
    {
        public bool IsCleaning { get; set; } = true;
    }
}

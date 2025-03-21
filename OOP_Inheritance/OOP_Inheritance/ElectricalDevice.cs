﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Parent class (Base class)
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        { 
            IsOn = false;
        }
    }
}

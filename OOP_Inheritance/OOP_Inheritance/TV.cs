using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class
    internal class TV : ElectricalDevice
    {


        public TV(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watch to the TV!");
            }
            else
            {
                Console.WriteLine("First switch it. TV is switched off!");
            }
        }
    }
}

using System;


namespace OOP_Inheritance
{
    // Child class
    internal class Radio : ElectricalDevice
    {

        public Radio(bool isOn, string brand) : base(isOn, brand) { }


        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listen to the radio!");
            }
            else
            {
                Console.WriteLine("First switch it. Radio is switched off!");
            }
        }

    }
}

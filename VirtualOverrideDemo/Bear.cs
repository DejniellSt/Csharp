using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Bear : Animal
    {
        public Bear(string name, int age):base(name, age)  {}
        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("ur ur ur ur ur ");
        }

    }
}

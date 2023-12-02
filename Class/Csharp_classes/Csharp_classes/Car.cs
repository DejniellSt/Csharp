using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_classes
{
    internal class Car
    {
        // Attributes 
        private string _name;
        private int _hp;
        private string _color;

        // Default Constructor 
        public Car()
        {
            _name = "BMW";
            _hp = 100;
            _color = "red";
        }
        // Partial Specification Constructor  
        public Car(string name , int hp ) {
            _name = name;  
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = "White";
        }    
        // Full Specification Constructor  
        public Car(string name , int hp ,string color ) {
            _name = name;  
            Console.WriteLine($"{name} was created");
            _hp = hp;
            _color = color;
        }

        // Method 
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }
        public void Stop()
        {
            Console.WriteLine($"{_name} is stop");
        }
        public void Details()
        {
            Console.WriteLine("The car " + _name + " has " + _hp + " hp" + " color "+_color );
        }

        // Getters and Setters
        public void setName(string name)
        {
            if (name == "")
            {
                _name = "DefaultName";
            }
            else
            {
                _name = name;
            }
        }

        public string getName() // not void because getter return something 
        {
            return _name;
        }

        public int getHp()
        {
            return _hp ;
        }
    }
}

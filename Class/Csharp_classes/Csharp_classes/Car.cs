﻿using System;
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
        private int _minSpeed;

        // Default Constructor 
        public Car()
        {
            _name = "BMW";
            _hp = 100;
            _color = "red";
            _minSpeed = 15;
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
            Console.WriteLine($"{_name} Driving test");
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
        public void SetName(string name)
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

        public string GetName() // not void because getter return something 
        {
            return _name;
        }

        public int GetHp()
        {
            return _hp ;
        }

        // Properties
        // public property 
        public string Name 
        {
            get
            { 
                return _name; 
            } // get accesor 
            set 
            { 
                if (value == "")
                {
                    value = "Yo default properties working";
                }
                else
                {
                    _name = value;
                }
            } // set accesor 
        }

        // Auto implemented properties 
        public int MaxSpeed { get; set; }

        // Read only accesor - getter without set , Write only accesor - setter without get
        public int MinSpeed { get; } = 10; // Read only accesor 
        public int MinSpeed2
        { 
            set
            {
                _minSpeed = value;
                Console.WriteLine("Write only acceors works " + value);
            }
        }
    }
}

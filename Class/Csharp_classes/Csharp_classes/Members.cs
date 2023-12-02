using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_classes
{
    internal class Members
    {
        // members - private field 
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // member - public field 
        public int age;

        // private member - property 
        public string JobTitle 
        {
            get 
            {
                return jobTitle;
            }
            set 
            {
                jobTitle = value;
            }
        }

        // public member - property 
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharedPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, job title is {1}, I'm {2} ",memberName,jobTitle,age);
            }

        }

        private void SharedPrivateInfo()
        {
            Console.WriteLine("My salary is  "+salary);
        }

        // member constructor 
        public Members()
        {
            Console.WriteLine("Obj created");
            age = 30;
            memberName = "Dejniel";
            salary = 9000;
            jobTitle = "Developer";
        }

        // member finalizer - destructor 
        ~Members()
        {
            // cleanup statements 
            Console.WriteLine("Destruction of Members obj");
            Debug.Write("Descrution of Members obj");
        }
    }
}

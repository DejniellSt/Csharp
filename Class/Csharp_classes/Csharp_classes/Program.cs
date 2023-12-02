using System.Security.Cryptography.X509Certificates;

namespace Csharp_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car DCar = new Car();
            // Setters
            DCar.SetName("");
            // Getters
            Console.WriteLine("Getter working : " + DCar.GetName());
            Console.WriteLine("Getter hp : " + DCar.GetHp());
            DCar.Details();
            Car C1 = new Car("Audi",100,"Grey");
            C1.Details();
            C1.Drive();
            // Prop test 
            Car PropTest = new Car();
            //Console.WriteLine(PropTest.Name);
            PropTest.Name = "";
            PropTest.Details();

            // Auto implemented properties 
            Car AutoProp = new Car();
            AutoProp.MaxSpeed = 200;
            Console.WriteLine("Max speed is : " + AutoProp.MaxSpeed);

            // Read only / Write only accesor 
            Car RWcar = new Car();
            Console.WriteLine("Read only accesor works : " + RWcar.MinSpeed);
            RWcar.MinSpeed2 = 20;
            */
            Members members1 = new Members();
            members1.Introducing(true);

        }
    }
}

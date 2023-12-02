namespace Csharp_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car DCar = new Car();
            DCar.setName("");
            Console.WriteLine("Getter working : " + DCar.getName());
            Console.WriteLine("Getter hp : " + DCar.getHp());
            DCar.Details();
            Car C1 = new Car("Audi",100,"Grey");
            C1.Details();
            Car C2 = new Car("VW",350,"blue");
            C2.Details();
            C1.Drive();
            C2.Drive();
            Console.WriteLine("Press 1 to stop the car");

            string userInput = Console.ReadLine();
            if(userInput == "1") {
                C1.Stop();
                C2.Stop();
            }
            else
            {
                Console.WriteLine("Car still driving");
            }
        }
    }
}

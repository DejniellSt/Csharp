namespace Csharp_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            
        }
    }
}

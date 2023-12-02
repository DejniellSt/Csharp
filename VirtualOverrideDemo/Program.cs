namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog D1 = new Dog("Doggy",10);
            Console.WriteLine($"{D1.Name} is {D1.Age}");
            D1.Play();
            D1.MakeSound();
            D1.Eat();
            Bear B1 = new Bear("Freddy Fazbear",15);
            B1.Eat();
            B1.MakeSound();
        }
    }
}

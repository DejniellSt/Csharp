namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post("thanks for birthday",true,"Dejniel");
            Console.WriteLine(p1.ToString());
            
            ImagePost imageP1 = new ImagePost("Check my new ps4 games","Dejniel S","https://testsite.com",true);
            Console.WriteLine(imageP1.ToString());

            Console.ReadLine();
        }
    }
}

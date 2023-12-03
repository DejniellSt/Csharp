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

            VideoPost v1 = new VideoPost("FailVideo", "Dejniel", "https://testsite.com", true, 10);
            Console.WriteLine(v1.ToString());

            v1.Play();
            Console.WriteLine("Press any key to stop video");
            Console.ReadKey();
            v1.Stop();

            Console.ReadLine();
        }
    }
}

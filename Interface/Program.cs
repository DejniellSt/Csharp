namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));

            Ticket t3 = new Ticket(10);
            Ticket t4 = new Ticket(4);
            Console.WriteLine(t3.Equals(t4));
        }
    }
}

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio R1 = new Radio(false,"Sony");
            // method of the base class
            R1.SwitchOn();
            // method of the child class 
            R1.ListenRadio();

            TV t1 = new TV(false,"Sony");
            //t1.SwitchOn();
            t1.WatchTV();
        }
    }
}

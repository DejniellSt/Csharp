namespace EX_abstract_interface_diff;

class Program
{
    // Interface
    interface Timer
    {
        public void DisplyTime();
    }

    // Abstract class  
    abstract class BaseClock
    {
        public string Marka { get; set; }

        public abstract void SetTime(DateTime time);

        public void ShowMark()
        {
            Console.WriteLine($"Marka : {Marka}");
        }
    }

    // Base class
    class DigitalClock : BaseClock, Timer
    {
        private DateTime timeNow;

        public override void SetTime(DateTime time)
        {
            timeNow = time; 
        }

        public void DisplyTime()
        {
            Console.WriteLine($"Time now: {timeNow:HH:MM:ss}");
        }

    }


    static void Main(string[] args)
    {
        DigitalClock d1 = new DigitalClock();
        d1.Marka = "Rolex";
        d1.SetTime(DateTime.Now);

        d1.ShowMark(); // z klasy abstrakcyjnej
        d1.DisplyTime(); // z interfejsu 
    }
}
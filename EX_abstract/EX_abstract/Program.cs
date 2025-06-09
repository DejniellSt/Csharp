namespace EX_abstract;


public abstract class Vehicle
{
    public string Model { get; set; }
    public Vehicle (string model)
    {
        Model = model;
        Console.WriteLine(model);
    }
    public abstract void Start();
    public abstract void Stop();
}

public class Car : Vehicle
{
    public Car(string model) : base(model) { }
    public override void Start()
    {
        Console.WriteLine("Car start");
    }

    public override void Stop()
    {
        Console.WriteLine("Car stop");
    }
}

public class Motor : Vehicle
{
    public Motor(string model) : base(model) { }
    public override void Start()
    {
        Console.WriteLine("Motor start");
    }
    public override void Stop()
    {
        Console.WriteLine("Car stop");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car("Tesla");
        c1.Start();
        c1.Stop();

        Motor m1 = new Motor("HX1");
        m1.Start();
        m1.Stop();
    }
}


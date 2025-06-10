namespace EX_reference_type;

class Test
{
    public int Power { get; set; }
    public Test(int power)
    {
        Power = power;
        Console.WriteLine($"Constructor : {power}");
    }

    public override bool Equals(object? obj)
    {
        if(obj == null)
        {
            return false;
        }

        if (this.GetType() != obj.GetType())
            return false;

        Test testObj = (Test)obj;

        return this.Power == testObj.Power;
    }

    public static bool operator == (Test left, Test right)
    {
        return Equals(left, right);
    }

    public static bool operator != (Test left, Test right)
    {
        return !Equals(left, right);
    }

}


class Program
{
    static void Main(string[] args)
    {
        int power1 = 350;
        int power2 = 350;

        bool valueComper = power1 == power2;

        Console.WriteLine($"Value type compere : {valueComper}");

        Test t1 = new Test(500);
        Test t2 = new Test(500);

        //bool referenceComper = t1.Equals(t2);
        bool referenceComper = t1 == t2; 
        Console.WriteLine($"reference type compere  {referenceComper}");
    }
}


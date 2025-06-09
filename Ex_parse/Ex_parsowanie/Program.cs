namespace Ex_parsowanie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert the day of bith (dd.MM.yyyy)");
        string dateofBirhString = Console.ReadLine();
        DateTime dateOfBirth = DateTime.Parse(dateofBirhString);

        //DateTime dayOfBirth = new DateTime(year, month, day);

        TimeSpan timeSpan = DateTime.Now - dateOfBirth;

        Console.WriteLine($"You are born: {timeSpan.TotalDays} days ago");
        Console.ReadLine();
    }
}


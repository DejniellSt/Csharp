namespace CS_basic;

class Program
{
    // Nullable
    public class Uzytkownik
    {
        public string Imie { get; set; }
        public DateTime? DataOstatniegoLogowania { get; set; }
    }

    static void Main(string[] args)
    {
        Uzytkownik u1 = new Uzytkownik
        {
            Imie = "Testowe",
            // DataOstatniegoLogowania = null;
            DataOstatniegoLogowania = DateTime.Now
        };


        if (u1.DataOstatniegoLogowania.HasValue)
        {
            Console.WriteLine($"Ostatnie logowanie: {u1.DataOstatniegoLogowania.Value}");
        }
        else
        {
            Console.WriteLine("Brak logowania");
        }

    }
}
  


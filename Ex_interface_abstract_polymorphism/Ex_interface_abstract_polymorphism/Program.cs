using System;
using System.Collections.Generic;

// INTERFEJS – definiuje zachowanie
public interface IZwierze
{
    void DajGlos();
}

// KLASA ABSTRAKCYJNA – szablon z logiką
public abstract class Zwierze : IZwierze
{
    public string Imie { get; set; }

    public Zwierze(string imie)
    {
        Imie = imie;
    }

    // Metoda abstrakcyjna – wymagana implementacja w klasach dziedziczących
    public abstract void DajGlos();

    // Zwykła metoda – dostępna dla wszystkich potomków
    public void Jedz()
    {
        Console.WriteLine($"{Imie} je jedzenie.");
    }
}

// KONKRETNE KLASY – implementują metodę z klasy abstrakcyjnej
public class Pies : Zwierze
{
    public Pies(string imie) : base(imie) { }

    public override void DajGlos()
    {
        Console.WriteLine($"{Imie}: Hau hau!");
    }
}

public class Kot : Zwierze
{
    public Kot(string imie) : base(imie) { }

    public override void DajGlos()
    {
        Console.WriteLine($"{Imie}: Miau!");
    }
}

// PROGRAM – pokazuje POLIMORFIZM
class Program
{
    static void WydajDzwiek(Zwierze zwierze)
    {
        zwierze.DajGlos(); // polimorficzne wywołanie
    }

    static void Main()
    {
        // Lista zwierząt jako typ bazowy
        List<Zwierze> zwierzeta = new List<Zwierze>
        {
            new Pies("Reksio"),
            new Kot("Mruczek")
        };

        foreach (var zwierze in zwierzeta)
        {
            WydajDzwiek(zwierze); // POLIMORFIZM
            zwierze.Jedz();       // dostęp do metody z klasy abstrakcyjnej
        }

        // Bonus: interfejs
        IZwierze inneZwierze = new Pies("Azor");
        inneZwierze.DajGlos(); // też działa, bo Pies implementuje interfejs
    }
}

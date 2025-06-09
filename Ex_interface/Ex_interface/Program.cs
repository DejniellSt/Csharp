namespace Ex_interface;

// EX_1 
/*interface IFile
{
    string FileName { get; set; }
    int Size { get; set; }
    DateTime CreatedOn { get; set; }
    void Compress();
}

interface IOther
{
    void Display();
}

class ExcelFile : IFile, IOther
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }

    public void Compress()
    {
        Console.WriteLine("Compressing ExcelFile");
    }

    public void Display()
    {
        Console.WriteLine("test");
    }

}*/


// EX_2
interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Rectangle : IShape
{
    int a, b;
    public Rectangle(int A, int B)
    {
        Console.WriteLine("Constructor");
        a = A;
        b = B;
    }

    public void CalculateArea()
    {
        int wynik = 2*b;
        Console.WriteLine($"{wynik}");
    }
    public void CalculatePerimeter()
    {
        int wynik = 2 * a + 2 * b;
        Console.WriteLine($"{wynik}");
    }
}

public class Circle : IShape
{
    public int r;
    public int h;
    public Circle(int R, int H)
    {
        Console.WriteLine("Constructor");
        r = R;
        h = H;
    }
    public void CalculateArea()
    {
        double wyniki = 3.14 * r * h;
        Console.WriteLine($"{wyniki}");

    }
    public void CalculatePerimeter()
    {
        double wynik = 2 * 3.14 * r;
        Console.WriteLine($"{wynik}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        /*ExcelFile f1 = new ExcelFile();
        f1.Compress();
        f1.Display();*/

        Rectangle c1 = new Rectangle(12, 12);
        c1.CalculateArea();
        c1.CalculatePerimeter();

        Circle r1 = new Circle(12, 23);
        r1.CalculateArea();
        r1.CalculatePerimeter();
    }
}


namespace EX_ref_out;

class TemperatureConverter
{
    public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
    {
        fahrenheit = (celsius * 9.0 / 5.0) + 32;
    }

    public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
    {
        celsius = (fahrenheit - 32) * 5.0 / 9.0;
    }

}


class Program
{
    static void just_Value(int value)
    {
        value = 2 * value;
        Console.WriteLine($"Double value : {value}");
    }

    // Example of ref 
    static void ref_Value(ref int value)
    {
        value = 2 * value;
        Console.WriteLine($"Ref value : {value}");
    }

    // Example of ref and out
    static bool IsDivisible(int value, int factor, out int reminder)
    {
        reminder = value % factor;

        return reminder == 0;
    }

    // Example 2 of ref and out
    static void Field_calc(ref int width, ref int heigh, out int field, out int perimeter)
    {
        width += 2;
        heigh += 2;
        field = width * heigh;
        perimeter = 2 * (width + heigh);
    }

    static void Main(string[] args)
    {
        int value = 5;
        int factor = 2;
        int reminder;

        Console.WriteLine("Value ...");
        int someValue = 5;
        just_Value(someValue); // 10
        Console.WriteLine($"Some value : {someValue}"); // 5

        Console.WriteLine("Ref Value ...");
        ref_Value(ref someValue); // 10
        Console.WriteLine($"Ref Value : {someValue}"); // 10

        Console.WriteLine("Out");
        if(IsDivisible(value,factor,out reminder))
        {
            Console.WriteLine($"Value is divisible by {factor}");
        }
        else
        {
            Console.WriteLine($"{value} is not divisile by {factor}. Remider : {reminder} ");
        }


        Console.WriteLine("Field and permimeter ...");

        int heigh = 4;
        int width = 3;
        int field, permiter;

        Field_calc(ref width, ref heigh, out field, out permiter);
        Console.WriteLine($"Width : {width}"); // 5
        Console.WriteLine($"Heigh : {heigh}"); // 6
        Console.WriteLine($"Field : {field}"); // 30
        Console.WriteLine($"Permieter : {permiter}"); // 22

        Console.WriteLine("Excercise ...");

        

        TemperatureConverter t1 = new TemperatureConverter();
        double celsius = 20;
        double fahrenheit;

        // out wynik przypisany w metodzie 
        t1.ConvertCelsiusToFahrenheit(celsius, out fahrenheit);
        Console.WriteLine($"{celsius} C = {fahrenheit} F");


        fahrenheit = 77;
        double result_Celsius = 0; // ref musi byc zainicjalizowany przed przekazaniem
        t1.ConvertFahrenheitToCelsius(fahrenheit, ref result_Celsius);
        Console.WriteLine($"{fahrenheit} F = {result_Celsius} C");

    }
}


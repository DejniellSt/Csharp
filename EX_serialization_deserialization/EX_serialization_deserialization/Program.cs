using System;
using System.Text.Json;

namespace SerializationExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person() { } // konstruktor bezargumentowy, uzywany przy deserializacji 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Dejniel", 30);

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine("\nDeserialized object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");

            Console.ReadLine();
        }
    }
}

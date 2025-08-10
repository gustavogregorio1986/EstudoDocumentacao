using System;

namespace Estudo12
{
    public record Person(string FirstName, string LastName);
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Gustavo", "Kuzava");
            Console.WriteLine(person);
        }
    }
}

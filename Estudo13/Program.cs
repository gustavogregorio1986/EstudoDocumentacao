using System;

namespace Estudo13
{
    public record Person(string FirstName, string LastName, string[] phoneNumbers);

    public class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new string[2]; 
            Person person1 = new("John", "Doe", phoneNumbers);
            Person person2 = new("Gustavo", "Kuzava", phoneNumbers);
            Console.WriteLine(person1 == person2);

            person1.phoneNumbers[0] = "123-456-7890";
            Console.WriteLine(person1 == person2);

            Console.WriteLine(ReferenceEquals(person1, person2));
        }
    }
}

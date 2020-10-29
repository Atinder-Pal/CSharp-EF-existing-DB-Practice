using ExistingDBPractice.Models;
using System;
using System.Linq;

namespace ExistingDBPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please enter a First Name: ");
            input = Console.ReadLine().Trim();

            // Dispose of whatever is in the parentheses when the code block ends.
            using (PersonContext context = new PersonContext())
            {
                try
                {                    
                    Person person = context.Person.Where(x => x.FirstName.ToLower() == input.ToLower()).Single();              
                    Console.WriteLine($"Full Name of this person is-{person.FirstName} {person.LastName} ");               
                }
                catch
                {
                    Console.WriteLine("ERROR: Name not found.");
                }
            }
        }
    }
}

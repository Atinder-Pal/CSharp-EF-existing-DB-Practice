using ExistingDBPractice.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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
                List<Person> people = context.Person.Where(x => x.FirstName.ToLower() == input.ToLower()).ToList();
                foreach (Person person in people)
                {
                    Console.WriteLine($"Full Name of this person is-{person.FirstName} {person.LastName} ");
                }
                //Citation
                //How to check if list is empty
                //https://www.tutorialspoint.com/How-to-check-if-a-Chash-list-is-empty
                if (!people.Any())
                {
                    Console.WriteLine("ERROR: Name not found.");
                }
            }
        }
    }
}

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
            bool isValid = false;
            while(!isValid)
            {
                Console.Write("Please enter a First Name: or type 'quit' to exit ");
                input = Console.ReadLine().Trim();
                if( !(input.ToLower() == "quit") )
                {
                    using (PersonContext context = new PersonContext())
                    {
                        List<Person> people = context.Person.Where(x => x.FirstName.ToLower() == input.ToLower()).ToList();
                        //Citation
                        //How to check if list is empty
                        //https://www.tutorialspoint.com/How-to-check-if-a-Chash-list-is-empty
                        isValid = people.Any();
                        //End Citation
                        if (isValid)
                        {
                            foreach (Person person in people)
                            {
                                Console.WriteLine($"Full Name of this person is-{person.FirstName} {person.LastName} ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Name not found.");
                        }
                    }
                }
                else
                {
                    isValid = true;
                }
            }          
        }
    }
}

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
                                List<string> ph = context.Phonenumber.Where(x => x.PersonId == person.Id).Select(y => y.Number).ToList();
                                Console.WriteLine($"Full Name of this person is-{person.FirstName} {person.LastName}  and Phone Number is ");
                                //Citation
                                //https://stackoverflow.com/questions/15350363/iterating-through-a-list-with-out-using-foreach-loop                                
                                ph.ForEach(i => Console.WriteLine(i));  
                                //End Citation
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

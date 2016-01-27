using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myFriends = new Persons();

            // create a friends...
            Person person1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSecurityNumber = "010101-011E" };
            Person person2 = new Person { Firstname = "Onni", Lastname = "Ojansuu", SocialSecurityNumber = "222222-022Q" };
            Person person3 = new Person { Firstname = "Aatu", Lastname = "Virtanen", SocialSecurityNumber = "131213-133Y" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection:");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            // find person with sotu
            string socialSecurityNumber = "222222-022Q";
            Console.WriteLine("Find person with sotu :" + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found...");
            }
        }
    }
}

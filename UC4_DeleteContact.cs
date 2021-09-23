using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day9_AddressBook
{
    class UC4_DeleteContact
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public static List<UC4_DeleteContact> People = new List<UC4_DeleteContact>();

        public static void NewContact()
        {
            UC4_DeleteContact person = new UC4_DeleteContact();

            Console.Write("Enter First Name: ");
            person.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            person.zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phonenumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();


            People.Add(person);
        }


        public static void PrintDetails(UC4_DeleteContact person)
        {
            Console.WriteLine("First Name: " + person.firstname);
            Console.WriteLine("Last Name: " + person.lastname);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip Code: " + person.zipcode);
            Console.WriteLine("Phone Number: " + person.phonenumber);
            Console.WriteLine("Email ID: " + person.email);
            Console.WriteLine("-------------------------------------------");
        }

        public static void ListContacts()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintDetails(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }

        public static void RemovePerson()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove:");
            string firstname = Console.ReadLine();
            //UC4_DeleteContact findperson = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
            UC4_DeleteContact findperson = People.FirstOrDefault(x => x.firstname.ToLower() == firstname.ToLower());
            if(findperson==null)
            {
                Console.WriteLine("That person could not be found");
            }

            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintDetails(findperson);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(findperson);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
            ListContacts();
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("OKK. Press any key to continue.");
            }
            
        }
    }
}

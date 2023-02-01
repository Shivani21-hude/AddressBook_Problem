using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CreateContact
    {
        public static List<Contact> person = new List<Contact>();
        public static void PersonDetails()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter First Name");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter EmailID ");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode ");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            person.Add(contacts);
 

        }
    }
}

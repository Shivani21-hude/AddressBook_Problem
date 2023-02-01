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
        internal static void PersonDetails()
        {
            
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name :");
            contact.firstname = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter Address :");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter city :");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter state :");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter zipcode :");
            contact.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile Number :");
            contact.phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email :");
            contact.email = Console.ReadLine();

            person.Add(contact);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CreateContact
    {
        internal static void EnterDetails()
        {
            List<string> PersonDetails = new List<string>();
            Console.WriteLine("Enter First Name :");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city :");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state :");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zipcode :");
            string zipcode = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Mobile Number :");
            string phonenumber = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter email : ");
            string email = Console.ReadLine();

           Console.WriteLine("\n Person Details : ");

           PersonDetails.Add(firstname);
            PersonDetails.Add(lastname);    
            PersonDetails.Add(address);
            PersonDetails.Add(city);
            PersonDetails.Add(state);
            PersonDetails.Add(zipcode);
            PersonDetails.Add(phonenumber);
            PersonDetails.Add(email);
            foreach(string i in PersonDetails)
            { 
                Console.WriteLine(i);
            }

        }
    }
}

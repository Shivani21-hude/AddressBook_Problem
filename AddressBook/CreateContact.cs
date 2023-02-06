using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContact
    {

        public static List<Contact> person = new List<Contact>();
        Dictionary<string, List<Contact>> book = new Dictionary<string, List<Contact>>();
        public static void PersonDetails()
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
        public static void Display()
        {
            foreach (var data in person)
            {
                Console.WriteLine();
                Console.WriteLine("1.FirstName: " + data.firstname + "\n2.LastName: " + data.lastname + "\n3.Address: " + data.address + 
                    "\n4.City: " + data.city + "\n5.State: " + data.state + "\n6.Zipcode: " + data.zipcode + "\n7.PhoneNumber: " 
                    + data.phonenumber +"\n8.Email : " + data.email);
            }
        }
        //Uc3
        //Edit contact details

        public static void EditContact()
        {

            if (person.Count != 0)
            {
                Console.WriteLine("\nEnter the First name  to Edit Contact of that person: ");
                string name = Console.ReadLine();
                foreach (var data in person)
                {
                    if (person.Contains(data))
                    {
                        if (data.firstname.ToUpper() == name.ToUpper())
                        {
                            Console.WriteLine("Enter the option to edit Contact \n  1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                            int option = Convert.ToInt32(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Enter new First name : ");
                                    data.firstname = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.WriteLine("Enter new Last name: ");
                                    data.lastname = Console.ReadLine();
                                    break;

                                case 3:
                                    Console.WriteLine("Enter new Address: ");
                                    data.address = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.WriteLine("Enter new City name: ");
                                    data.city = Console.ReadLine();
                                    break;

                                case 5:
                                    Console.WriteLine("Enter new State name: ");
                                    data.state = Console.ReadLine();
                                    break;

                                case 6:
                                    Console.WriteLine("Enter Zipcode: ");
                                    data.zipcode = Convert.ToInt32(Console.ReadLine());
                                    break;

                                case 7:
                                    Console.WriteLine("Enter new Mobile number: ");
                                    data.phonenumber = Convert.ToInt32(Console.ReadLine());
                                    break;

                                case 8:
                                    Console.WriteLine("Enter new Email : ");
                                    data.email = Console.ReadLine();
                                    break;

                                default:
                                    Console.WriteLine("Choose valid option");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Name doesnot match");
                        }
                    }
                }
            }
        }
        //Uc4
        //if name of person will match the first one then it will delete
        public void DeleteContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter FirstName of person whose name you want to delete ");
            string name = Console.ReadLine();
            foreach (var data in person.ToList())
            {
                if (data.firstname.ToUpper() == name.ToUpper())
                {
                    person.Remove(data);
                    Console.WriteLine("Contact is remove");

                }
                else

                {
                    Console.WriteLine("Contact is not present");
                }


            }
        }
            public void AddMultipleContacts()
            {
                Console.WriteLine("Enter the Number of Records of persons you want to Insert");
                int number = (int)Convert.ToInt64(Console.ReadLine());
                while (number > 0)
                {
                    PersonDetails();
                    number--;
                }
            }
        public void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {

                number--;
                PersonDetails();
            }
            book.Add(Bookname, person.ToList());
        }
        public void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contact data in book[pair])
                {
                    Console.WriteLine("****First Name***: " + data.firstname);
                    Console.WriteLine("Last Name: " + data.lastname);
                    Console.WriteLine("Address: " + data.address);
                    Console.WriteLine("City : " + data.city);
                    Console.WriteLine("State: " + data.state);
                    Console.WriteLine("Zip : " + data.zipcode);
                    Console.WriteLine("Phone Number: " + data.phonenumber);
                    Console.WriteLine("EmailID: " + data.email);
                }
            }
        }
        public void DuplicateContact()
        {
            Console.WriteLine("Enter the name to check: ");
            string PersonName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            int mobilenumber = Convert.ToInt32(Console.ReadLine());
            bool check = person.Any(e => e.firstname == PersonName && e.phonenumber == mobilenumber);
            if (check)
            {
                Console.WriteLine("Contact is present");
            }
            else
            {
                Console.WriteLine("Contact is not present");

            }
        }

    }
}

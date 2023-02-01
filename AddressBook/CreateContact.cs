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
        //Uc3
        //Edit contact details

        public static void EditContact()
        {

            if (person.Count != 0)
            {
                Console.WriteLine("Enter the First name  to Edit Contact of that person: ");
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
        
    }
}

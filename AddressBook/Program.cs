using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Address Book Program");
            CreateContact createContact = new CreateContact();
            while (true)
            {
                Console.WriteLine("\n Select Option:\n" +
                    "1) Create Contact of a person\n" +
                    "2) Display of created information of person\n" +
                    "3) Edit contact\n" +
                    "4) Delete contacts\n" +
                    "5) Ability to add Multiple persons in AddressBook\n" +
                     "6) Add multiple address book\n" +
                     "7) Display new list\n"+
                    "8)Check Duplicate entry\n");
                int option = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                switch (option)
                {
                    case 1:
                        CreateContact.PersonDetails();
                        break;

                    case 2:
                        CreateContact.Display();
                        break;

                    case 3:
                        CreateContact.EditContact();
                        break;

                    case 4:
                        Console.WriteLine("Enter name to delete the contact");
                        string name = Console.ReadLine();
                        createContact.DeleteContact();
                        break;

                    case 5:
                        createContact.AddMultipleContacts();
                        break;
                    case 6:
                        createContact.NewUser();
                        break;
                    case 7:
                        createContact.DisplayList();
                        break; 
                    case 8:
                        createContact.DuplicateContact();
                        break;
                }
            }

        }
       
    }
}
       
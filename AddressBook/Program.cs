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
                     "7) Display new list\n" +
                    "8)Check Duplicate entry\n" +
                "9)Add City to Check person details\n" +
                "10)Add State to Check Person details\n" +
                "11)Ability to get number of contact persons count by City\n"+
                "12)Ability to Sort the Entries in Address Book\n"+
                "13)Ability to Sort the Entries in Address Book by Zipcode\n"+
                "14)Ability to Read the txt file\n"+
                "15)Ability to read/write person contact as CSV File\n"+
                "16)Ability to read/write person contact as JSON File\n");
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
                    case 9:
                        createContact.CheckPersonInCity();
                        break;
                    case 10:
                        createContact.CheckPersonInState();
                        break;
                    case 11:
                        createContact.CountPersonByCity();
                        break;
                    case 12:
                        createContact.SortPersonName();
                        break;
                    case 13:
                        createContact.SortbyZipcode();
                        break;
                    case 14:
                        AdressBookFileIO.ReadAllLines();
                        break;
                    case 15:
                        AddressBookCSVHandler.ImplementCSVDataHandling();
                        break;
                    case 16:
                        ReadCSV_And_WriteJSON.ImplementCSVToJSON();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
       
    }
}
       
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("      'Welcome to Address Book program'");
            Console.WriteLine("\n");
            CreateContact.PersonDetails();
            CreateContact.Display();
            CreateContact.EditContact();
            CreateContact.DeleteContact();
        }
    }
}
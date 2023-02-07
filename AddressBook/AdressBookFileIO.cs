using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AdressBookFileIO
    {
        public static void FileExists()
        {
            String path = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\AddressBook.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }


        public static void ReadAllLines()
        {
            String path = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\AddressBook.txt";
            String[] lines;           
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[4]);

        }
    }
}

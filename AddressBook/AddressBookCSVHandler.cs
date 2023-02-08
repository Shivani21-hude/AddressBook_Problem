using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookCSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\Utility\\Addresses.csv";
            string exportFilePath = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\Utility\\export.csv";

            //reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (var addressData in records)
                {
                    Console.Write("\t" + addressData.firstname);
                    Console.Write("\t" + addressData.lastname);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.zipcode);
                    Console.Write("\t" + addressData.phonenumber);
                    Console.Write("\t" + addressData.email);
                    Console.WriteLine();

                }
                Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
                //Writing csv file

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvImport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvImport.WriteRecords(records);
                }
            }
            //Console.WriteLine(reader);
        }
    }
}

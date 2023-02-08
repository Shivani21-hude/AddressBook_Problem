using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;


namespace AddressBook
{
    internal class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\Utility\\Addresses.csv";
            string exportFilePath = "E:\\RFP 215\\AddressBook\\AddressBook_Problem\\AddressBook\\Utility\\export.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (Contact addressData in records)
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
                Console.WriteLine("**********************Reading fromcsv file and Write to Json file **************************");

                //Writing json file

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }

            }
        }
    }
}

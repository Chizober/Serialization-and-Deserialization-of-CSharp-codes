using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    public class Data
    {
        StudentDetails studentDetails = new StudentDetails
        {
            Id = "1234",
            Gender = "Female",
            fullName = new FullName { FirstName = "Alexandra", LastName = "Marion" },
            contact = new Contact
            {
                PhoneNumber = "090-234-123",
                dateOfBirth = new DateOfBirth
                {
                    Year = 1901,
                    Month = 4,
                    Day = 27
                },
                Myaddress = new Address
                {
                    Street = "NO 12 Godwin Avenue",
                    City = "Enugu",
                    State = "Enugu",
                    Country = "Nigeria"
                }
            },
            courses = new List<string>() { "English", "Mathematics", "Home Science", "Computer" },
        };

        public void Details()
        {
            Console.WriteLine("\n\t\tThis is Serialization \n");

            var options = new JsonSerializerOptions { WriteIndented = true };
            string stringjson = JsonSerializer.Serialize(studentDetails, options);
            Console.WriteLine($"{stringjson}\n");

            Console.WriteLine("\n\t\tDeserialized JSON string  back to object: ");
            var person = JsonSerializer.Deserialize<StudentDetails>(stringjson);

            Console.WriteLine($"Id:{person.Id}");
            Console.WriteLine($"Name:{person.Gender}");
            Console.WriteLine($"FirstName:{person.fullName.FirstName}");
            Console.WriteLine($"LastName:{person.fullName.LastName}");
            Console.WriteLine($"PhoneNumber:{person.contact.PhoneNumber}");
            Console.WriteLine($"Day:{person.contact.dateOfBirth.Day}");
            Console.WriteLine($"Month:{person.contact.dateOfBirth.Month}");
            Console.WriteLine($"Year:{person.contact.dateOfBirth.Year}");
            Console.WriteLine($"Street:{person.contact.Myaddress.Street}");
            Console.WriteLine($"City:{person.contact.Myaddress.City}");
            Console.WriteLine($"State:{person.contact.Myaddress.State}");
            Console.WriteLine($"Country:{person.contact.Myaddress.Country}");
            foreach (string course in person.courses)
            {
                Console.WriteLine($"Courses :{course}");
            }
        }
    }
}

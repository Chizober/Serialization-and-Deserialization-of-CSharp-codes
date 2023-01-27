using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    
        public class StudentDetails
        {
            public string? Id { get; set; }
            public string? Gender { get; set; }
            public FullName? fullName { get; set; }
            public Contact? contact { get; set; }
            public List<string>? courses { get; set; }
        }

        public class FullName
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        }

        public class Address
        {
            public string? Street { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
            public string? Country { get; set; }
        }

        public class DateOfBirth
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
        }

        public class Contact
        {
            public string? PhoneNumber { get; set; }
            public DateOfBirth? dateOfBirth { get; set; }
            public Address? Myaddress { get; set; }
        }

    }


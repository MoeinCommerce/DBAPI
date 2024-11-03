using System;

namespace DatabaseApi.Models
{
    public class Person : MappableModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; } = DateTime.UtcNow;
        public int Age => DateTime.UtcNow.Year - DateOfBirth.Year;
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Work.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string House_Number { get; set; }
        public string AddressString { get; set; }

        public IList<UserResource> UsersResources { get; set; }
        public User()
        {

        }
        public User(string firstname, string lastname, string country, string city, string street, string housenumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House_Number = housenumber;

            this.AddressString = City + ", " + Country + ". St. " + Street + ", " + House_Number;
        }

    }
}

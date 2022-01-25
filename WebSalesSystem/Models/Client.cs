using System;
using System.ComponentModel.DataAnnotations;

namespace WebSalesSystem.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The name must contain at least 3 letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The last name must contain at least 3 letters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birth date required")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        [Required(ErrorMessage = "Cpf required")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Cell required")]
        [DataType(DataType.PhoneNumber)]
        public string Cell { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Cep { get; set; }

       // [Required(ErrorMessage = "State required")]
        public string State { get; set; }

        [Required(ErrorMessage = "City required")]
        public string City { get; set; }

        [Required(ErrorMessage = "District required")]
        public string District { get; set; }

        [Required(ErrorMessage = "Street required")]
        public string Street { get; set; }

        [Required(ErrorMessage = "House number required")]
        public int HouseNumber { get; set; }

        public Client()
        {

        }

        public Client(int id, string firstName, string lastName, DateTime birth,
                      string cpf, string cell, string email, string cep, string state,
                      string city, string district, string street, int houseNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            Cpf = cpf;
            Cell = cell;
            Email = email;
            Cep = cep;
            State = state;
            City = city;
            District = district;
            Street = street;
            HouseNumber = houseNumber;
        }
    }
}

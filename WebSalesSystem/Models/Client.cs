using System;

namespace WebSalesSystem.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Cpf { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
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

using System;
namespace FarmApp
{
    public abstract class Details
    {
        public string Firstname{get; set;}
        public string Lastname{get; set;}
        public string Email{get; set;}
        public string Address{get; set;}
        public string Phone{get; set;}

        public Details(string firstname, string lastname, string email, string address, string phone)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Address = address;
            Phone = phone;
        }

        
    }
}
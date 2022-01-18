using System;
using System.Collections.Generic;

namespace FarmApp
{
    public class Customer:Details
    {
        public string CustomerId{get;}
        private static int NoOfCustomers = 0;
        public const string Farm = "AgroFarm foods";
        private static List<Customer> customers = new List<Customer>();
        public int TotalPurchase{get;set;}

        public Customer(string firstname, string lastname, string email, string address, string phone):base(firstname, lastname, email, phone, address)
        {
            CustomerId = GenerateCustomerId();
            AddCustomer();
            NoOfCustomers++;
            //TotalPurchase = GetTotalPurchase(price);
            
            
        }

        public void AddCustomer()
        {
            customers.Add(this);
        }

        private string GenerateCustomerId()
        {
            Random num = new Random();
            var no = num.Next(10,10001);
            return $"CUS{no:00000}";
        }
        public void PrintRegristrationDetails()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Dear {Firstname}, welcome to {Farm}.\nRegistration successful your regno is:{CustomerId}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GetTotalPurchase(int totalPurchase)////////////////////////////////
        {
            TotalPurchase = totalPurchase;
        }

        public static void AllCustomers()
        {
            for(int i =0; i<NoOfCustomers; i++)
            {
                Console.WriteLine($"{i +1}. {customers[i].CustomerId}: {customers[i].Lastname} - {customers[i].Firstname} {customers[i].Address} {customers[i].Phone}");
            }
        }


        

    }
}
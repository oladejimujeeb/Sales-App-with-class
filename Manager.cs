using System;
using System.Collections.Generic;

namespace FarmApp
{
    public class Manager: Details
    {
        public string ManageId{get;}
        private static int NoOfManagers = 0;
        public const string Farm = "AgroFarm foods"; 
        private static List<Manager> managers = new List<Manager>();
        public static List<string> transactionHistory = new List<string>();
    

      
        public Manager(string firstname, string lastname, string email, string address, string phone):base(firstname, lastname, email, phone, address)
        {
            AddManager();
            NoOfManagers++;
            ManageId = GenerateManagerId();
        }

        public void AddManager()
        {
            managers.Add(this);
        }

        private string GenerateManagerId()
        {
            Random num = new Random();
            var no = num.Next(1,101);
            return $"MAG{no:000}";
        }

        public void WelcomeNote()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Dear {Firstname}, The management welcome to {Farm}.\nRegistration successful your regno is:{ManageId}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AddProductToList()
        {
            Console.Write("Enter the name of the Product: ");
            var productname = Console.ReadLine();
            Console.Write("Enter the Product quantity: ");
            var productquantity = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the cost price: ");
            var unitCP = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the selling price: ");
            var unitSP = int.Parse(Console.ReadLine());
            
            Product product= new Product(productname,productquantity,unitCP,unitSP);
            product.AddNewProduct();
        }
        
        public static void RegisterCustomer()
        {
            Console.WriteLine("*****CUSTOMER REGISTRATION*********");
            Console.Write("Enter your Firstname: ");
            var firstname = Console.ReadLine();

            Console.Write("Enter your Lastname: ");
            var lastname = Console.ReadLine();

            Console.Write("Enter your Email: ");
            var email = Console.ReadLine();

            Console.Write("Enter your Address: ");
            var address = Console.ReadLine();

            Console.Write("Enter your Phone number: ");
            var phone = Console.ReadLine();

            var customer = new Customer(firstname,lastname,email,phone,address);
            customer.PrintRegristrationDetails();
        }
        

        public static void MakeSales()
        {
            Product.ListallProduct ();
            Console.Write("Enter ProductID: ");
            string productID = Console.ReadLine();
            Product product =Product.GetProduct(productID);
            if(product != null && product.Productquantity>0)
            {
                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                int totalPurchase= product.UnitSP*quantity;
                product.Productquantity -=quantity;
                DateTime time = DateTime.Now;
                

                Console.WriteLine($"Payment of {product.Productname} successful\n Total price:{totalPurchase}\n Date of Transaction: {time}");
                string are =$"Payment of {product.Productname} successful Total price:{totalPurchase} Date of Transaction: {time}";
                transactionHistory.Add(are);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product not found/Out of Stock");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static Manager GetManager(string id)
        {
            foreach (var manager in managers)
            {
                if(manager.ManageId==id)
                {
                    return manager;
                }
               
            }
            return null;
        }
        public static void transHistory()
        {
            foreach(var item in transactionHistory)
            {
                Console.WriteLine(item);
            }
        }

    }
    
}
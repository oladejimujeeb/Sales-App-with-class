using System;
using System.Collections.Generic;

namespace FarmApp
{
    public class Product
    {
        public string Productname{get; set;}
        public string ProductID{get;}
        public int Productquantity{get; set;}
        public int UnitCP{get; set;}
        public int UnitSP{get; set;}
        public int TotalCP{get;}
        public int TotalSP{get;}
        private static int NoOfProducts = 0;
        public const string Farm = "AgroFarm foods"; 
        private static List<Product> products = new List<Product>();

        public Product(string productname, int productquantity, int unitCP, int unitSP)
        {
            Productname = productname;
            Productquantity = productquantity;
            UnitCP = unitCP;
            UnitSP = unitSP;
            TotalSP = Productquantity * UnitSP;
            TotalCP = Productquantity * UnitCP;
            NoOfProducts++;
            ProductID = GetProductID();
            AddProduct();
        }
        public void AddProduct()
        {
            products.Add(this);
        }

        private string GetProductID()
        {
            Random num = new Random();
            var no = num.Next(10,10001);
            return $"AgroProd{no:00000}";
        }

        public void AddNewProduct()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Productname} with ID Number:{ProductID} successfully added");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AllProducts()
        {
            for(int i =0; i<products.Count; i++)
            {
                Console.WriteLine($"{i +1}. {products[i].ProductID}: {products[i].Productname}  Quantity:{products[i].Productquantity} Selling Price:{products[i].UnitSP} CostPrice{products[i].UnitCP} Total Value:{products[i].TotalSP}");
            }
        }
        public static void ListallProduct()
        {
            for(int i =0; i<products.Count; i++)
            {
                Console.WriteLine($"{i +1}. {products[i].ProductID}: {products[i].Productname}  Selling Price:{products[i].UnitSP}");
            }
        }
        public static Product GetProduct(string id)
        {
            foreach (var product in products)
            {
                if(product.ProductID==id)
                {
                    return product;
                }
               
            }
            return null;
        }
    }
}
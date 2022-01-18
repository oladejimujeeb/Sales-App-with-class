using System;
namespace FarmApp
{
    public class Login
    {
        public static void ManagerLogin()
        {
            Console.Write("Enter your ID:");
            string managerID = Console.ReadLine();
            Manager manager = Manager.GetManager(managerID);
            if(manager != null)
            {
                while(true)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" Welcome Dear {manager.Firstname},\nHere are list of what you can do");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter 1 to Add new Product\nEnter 2 to Add customer \nEnter 3 to Sell product\nEnter 4 to list all customers");
                    Console.WriteLine("Enter 5 to list all Product\nEnter 6 to View history\nEnter 7 to logout");
                    Console.Write("Enter choice: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    int input = int.Parse(Console.ReadLine());
                    if(input <7 )
                    {   switch (input)
                        {
                            case 1:
                                Manager.AddProductToList();
                                break;
                            case 2:
                                Manager.RegisterCustomer();
                                break;
                            case 3:
                                Manager.MakeSales();
                                break;
                            case 4:
                                Customer.AllCustomers();
                                break;
                            case 5:
                                Product.AllProducts();
                                break;
                            case 6:
                                Manager.transHistory();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }    
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect ID\nRegister or Reset Password");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
    }
}
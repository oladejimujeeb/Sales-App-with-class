using System;
using System.Collections.Generic;

namespace FarmApp
{
    public class Menu
    {
        public static void AppMenu()
        {   
            
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to AgroFarm foods Nigeria Ltd");
                Console.WriteLine("Enter 1 to Register new Manager\nEnter 2 to Login");
                Console.WriteLine("Enter 3 to exit");
                Console.ForegroundColor = ConsoleColor.White;
                int input = int.Parse(Console.ReadLine());
                if(input <3 )
                {   switch (input)
                    {
                        case 1:
                            RegisterManager();
                            break;
                        case 2:
                            Login.ManagerLogin();
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
        public static void RegisterManager()
        {
            Console.WriteLine("*****MANAGER'S REGISTRATION*********");
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

            var manager = new Manager(firstname,lastname,email,phone,address);
            manager.WelcomeNote();
        }
        
    }
}
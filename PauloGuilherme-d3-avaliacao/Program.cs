// Bcrypt
using Models;
using Repositories;

namespace InitialMenu
{
    internal class Program
    {
        // Method to show the menu
        static void ShowMenu(){
            Console.WriteLine("\n-------MENU--------");
            Console.WriteLine("1) Access system");
            Console.WriteLine("2) Cancel operation");
        }

        //Method to show the second menu
        static void ShowMenu2(){
            Console.WriteLine("\n-------SECOND MENU--------");
            Console.WriteLine("1) Log out");
            Console.WriteLine("2) Turn off system");
        }

        // Method to realize the login process:
        static string?[] LoginProtocol(){
            string? email, password;
            string?[] DateAndHour, LoginInfo = new string[2];

            Console.Write("Write your email:");
            email = Console.ReadLine();
        
            Console.Write("Write your password:");
            password = Console.ReadLine();

            LoginInfo = UserRepository.CheckUserPassword(email, password);
            DateAndHour = TakeCurrentDateAndHour();


            if(LoginInfo[0] != null && LoginInfo[1] != null){
                Console.WriteLine("Login executed with success. Showing new menu:\n");
            }else{
                Console.WriteLine("Username or password are wrong, please try again.");
            }
            return LoginInfo;
        }

        // Method to take current date and hour
        static string[] TakeCurrentDateAndHour(){
            string[] DateAndHour = DateTime.UtcNow.ToString().Split(" ");
            string[] FormatedDateAnHour = {DateAndHour[0], $"{DateAndHour[1]} {DateAndHour[2]}"};
            return FormatedDateAnHour;
        }

        // Method to take an action given an option in the second menu
        static bool DoChoosedOption2(string? option){
            bool running2 = true;
            if(option == null){
                Console.WriteLine("Error: Option choosed is null");
                return running2;
            }

            switch(option)
            {
                case "1":
                    Console.WriteLine("Logging out");
                    running2 = false;
                    break;
                case "2":
                    Console.WriteLine("Turning off system");
                    running2 = false;
                    break;
                default:
                    Console.WriteLine("Please, choose a command from the menu:");
                    break;
            }

            return running2;
        }

        // Method to take an action given an option in the main menu
        static bool DoChoosedOption(string? option){
            bool running = true;
            if(option == null){
                Console.WriteLine("Error: Option choosed is null");
                return running;
            }
            switch(option)
            {
                case "1":
                    string?[] LoginInfo = LoginProtocol();
                    if(LoginInfo[0] != null && LoginInfo[1] != null){
                        UserAccess userAccess = new(LoginInfo);
                        string[] FormatedDateAndHour = TakeCurrentDateAndHour();
                        userAccess.SaveUserAcessInfo(userAccess, FormatedDateAndHour);
                        string? option2;
                        bool running2;

                        do
                        {
                            ShowMenu2();

                            option2 = Console.ReadLine();
                            
                            running2 = DoChoosedOption2(option2);

                        }while(running2);
                        
                        FormatedDateAndHour = TakeCurrentDateAndHour();
                        userAccess.SaveUserLogOutInfo(userAccess, FormatedDateAndHour);
                        running = !(option2 == "2"); 

                    }
                    break;
                case "2":
                    Console.WriteLine("Finishing program");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please, choose a command from the menu:");
                    break;
            }

            return running;
        }

        //Main function
        static void Main(string[] args)
        {
            bool running;
            string? option;
            do
            {
                ShowMenu();

                option = Console.ReadLine();
                
                running = DoChoosedOption(option);

            }while(running);

        }
    }
}
using Models;
using UM = Utils.UtilsMethods;

namespace Menu
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
                    string?[] LoginInfo = UM.LoginProtocol();
                    if(LoginInfo[0] != null && LoginInfo[1] != null){
                        UserAccess userAccess = new(LoginInfo);
                        string[] FormatedDateAndHour = UM.TakeCurrentDateAndHour();
                        userAccess.SaveUserAcessInfo(userAccess, FormatedDateAndHour);
                        string? option2;
                        bool running2;

                        do
                        {
                            ShowMenu2();

                            option2 = Console.ReadLine();
                            
                            running2 = DoChoosedOption2(option2);

                        }while(running2);
                        
                        FormatedDateAndHour = UM.TakeCurrentDateAndHour();
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

        //Main function
        static void Main(string[] args){
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
// Bcrypt
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
        static string[] LoginProtocol(){
            string user, password;
            string[] LoginInfo = new string[3];

            Console.Write("Write your username:");
            LoginInfo[0] = Console.ReadLine();
        
            Console.Write("Write your password:");
            LoginInfo[1] = Console.ReadLine();

            // TODO:
            //LoginInfo[2] = CheckUserPassword(LoginInfo[0], LoginInfo[1]);
            LoginInfo[2] = "1";
            
            if(LoginInfo[2] == "1"){
                Console.WriteLine("Login executed with success. Showing new menu:\n");
            }else{
                Console.WriteLine("Username or password are wrong, please try again.");
            }
            return LoginInfo;
        }

        // Method to take an action given an option in the second menu
        static void DoChoosedOption2(string option){
            switch(option)
            {
                case "1":
                    Console.WriteLine("Logging out");
                    break;
                case "2":
                    Console.WriteLine("Turning off system");
                    break;
                default:
                    Console.WriteLine("Please, choose a command from the menu:");
                    break;
            }
        }
        
        // Method to take an action given an option in the main menu
        static bool DoChoosedOption(string option){
            bool running = true;
            switch(option)
            {
                case "1":
                    string[] LoginInfo = LoginProtocol();
                    if(LoginInfo[2] == "1"){
                        // TODO:
                        // Save user data in a csv file

                        string option2;

                        do
                        {
                            ShowMenu2();

                            option2 = Console.ReadLine();
                            
                            DoChoosedOption2(option2);

                        }while(option2 != "1" && option2 != "2");

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
            string option;

            do
            {
                ShowMenu();

                option = Console.ReadLine();
                
                running = DoChoosedOption(option);

            }while(running);

        }
    }
}
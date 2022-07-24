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

        // Method to take an action given an option
        static void DoChoosedOption(string option){
            switch(option)
            {
                case "1":
                    Console.WriteLine("Opening system:");
                    break;
                case "2":
                    Console.WriteLine("Finishing program");
                    break;
                default:
                    Console.WriteLine("Please, choose a command from the menu:");
                    break;

            }
        }

        static void Main(string[] args)
        {
            string option;

            do
            {
                ShowMenu();

                option = Console.ReadLine();
                
                DoChoosedOption(option);

            }while(option != "2");

        }
    }
}
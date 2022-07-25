using Repositories;

namespace Utils
{
    internal class UtilsMethods
    {
        // Method to realize the login process:
        public static string?[] LoginProtocol(){
            string? email, password;
            string?[] LoginInfo = new string[2];

            Console.Write("Write your email:");
            email = Console.ReadLine();
        
            Console.Write("Write your password:");
            password = Console.ReadLine();

            LoginInfo = UserRepository.TakeUserNameAndId(email, password);

            if(LoginInfo[0] != null && LoginInfo[1] != null){
                Console.WriteLine("Login executed with success. Showing new menu:\n");
            }else{
                Console.WriteLine("Username or password are wrong, please try again.");
            }
            return LoginInfo;
        }

        // Method to take current date and hour
        public static string[] TakeCurrentDateAndHour(){
            string[] DateAndHour = DateTime.UtcNow.ToString().Split(" ");
            string[] FormatedDateAnHour = {DateAndHour[0], $"{DateAndHour[1]} {DateAndHour[2]}"};
            return FormatedDateAnHour;
        }

    }
}
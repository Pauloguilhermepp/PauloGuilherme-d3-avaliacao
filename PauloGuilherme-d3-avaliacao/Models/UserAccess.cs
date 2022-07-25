// File with basic UserAccess methods
namespace Models
{
    internal class UserAccess: BasicFile{
        private string? IdUserAccess { get; set; }

        private string? Name { get; set; }

        // Email and password are not used by this class in the current project 

        // private string? Email { get; set; }

        // private string? Password { get; set; }

        private const string path = "UserAccessLogs/UserAccess.csv";

        // Class constructor
        public UserAccess(string?[] userAccessInfo)
        {
            Name = userAccessInfo[0];
            IdUserAccess = userAccessInfo[1];
            CreateFolderAndFile(path);
        }

        // Method to format a message of access

        private static string UserAccessedSystemMessage(UserAccess userAccess, string[] FormattedDateAndHour)
        {
            string line = $"The user {userAccess.Name} ({userAccess.IdUserAccess})";
            line += $" accessed the system at {FormattedDateAndHour[0]} on {FormattedDateAndHour[1]}";
            return line;
        }

        // Method to format a message of log out

        private static string UserLogOutSystemMessage(UserAccess userAccess, string[] FormattedDateAndHour)
        {
            string line = $"The user {userAccess.Name} ({userAccess.IdUserAccess})";
            line += $" logged out of the system at {FormattedDateAndHour[0]} on {FormattedDateAndHour[1]}";
            return line;
        }

        // Method to write a message of access

        public void SaveUserAccessInfo(UserAccess userAccess, string[] FormattedDateAndHour)
        {
            string[] line = { UserAccessedSystemMessage(userAccess, FormattedDateAndHour) };
            File.AppendAllLines(path, line);
        }

        // Method to write a message of log out

        public void SaveUserLogOutInfo(UserAccess userAccess, string[] FormattedDateAndHour)
        {
            string[] line = { UserLogOutSystemMessage(userAccess, FormattedDateAndHour) };
            File.AppendAllLines(path, line);
        }
    }   
}
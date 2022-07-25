namespace Models
{
    internal class UserAccess: BasicFile{
        private string IdUserAccess { get; set; } = string.Empty;

        private string Name { get; set; } = string.Empty;

        private const string path = "database/UserAccess.csv";

        public UserAccess(string[] userAccessInfo)
        {
            Name = userAccessInfo[0];
            IdUserAccess = userAccessInfo[1];
            CreateFolderAndFile(path);
        }

        private static string UserAccessedSystemMensage(UserAccess userAccess, string[] FormatedDateAnHour)
        {
            string line = $"The user {userAccess.Name} ({userAccess.IdUserAccess})";
            line += $" accessed the system at {FormatedDateAnHour[0]} on {FormatedDateAnHour[1]}";
            return line;
        }

        private static string UserLogOutSystemMensage(UserAccess userAccess, string[] FormatedDateAnHour)
        {
            string line = $"The user {userAccess.Name} ({userAccess.IdUserAccess})";
            line += $" logged out of the system at {FormatedDateAnHour[0]} on {FormatedDateAnHour[1]}";
            return line;
        }

        public void SaveUserAcessInfo(UserAccess userAccess, string[] FormatedDateAnHour)
        {
            string[] line = { UserAccessedSystemMensage(userAccess, FormatedDateAnHour) };
            File.AppendAllLines(path, line);
        }

        public void SaveUserLogOutInfo(UserAccess userAccess, string[] FormatedDateAnHour)
        {
            string[] line = { UserLogOutSystemMensage(userAccess, FormatedDateAnHour) };
            File.AppendAllLines(path, line);
        }
    }   
}
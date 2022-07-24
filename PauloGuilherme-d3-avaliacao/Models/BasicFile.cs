namespace read_write_files.Models
{

    public class BasicFile
    {
        //Method to create a csv file and its folder if it does not exist
        public static void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

    }
}

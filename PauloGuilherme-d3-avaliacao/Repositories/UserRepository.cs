using MySql.Data.MySqlClient;

namespace Repositories
{
    internal class UserRepository{

        public static void method(){
            Console.WriteLine("Oii");
        }
        public static string[] CheckUserPassword(string email, string password){
            string[] NameAndId = {null, null};

            string connStr = "server=localhost;user=root;database=PauloGuilherme_d3_avalicao;port=3306;password=Aa@299792458";
            
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "SELECT UserId, UserName FROM User WHERE UserEmail=@email AND UserPassword=@password";
                //string sql = "SELECT * FROM User";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                if (rdr.Read()){
                    NameAndId[0] = rdr[1].ToString();
                    NameAndId[1] = rdr[0].ToString();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            
            return NameAndId;
        }
    }
}
// File with methods to manipulate User database
using BC = BCrypt.Net.BCrypt;
using MySql.Data.MySqlClient;
namespace Repositories
{
    internal class UserRepository{
        // Method to take user name and Id during login
        public static string?[] TakeUserNameAndId(string? email, string? password){
            string?[] NameAndId = {null, null};

            if(email == null || password == null){
                Console.WriteLine("\nError: email or password are null");
                return NameAndId;
            }

            string connStr = "server=localhost;user=root;database=PauloGuilherme_d3_avalicao;port=3306;password=Aa@299792458";
            
            using(MySqlConnection conn = new MySqlConnection(connStr)){
                try{
                    conn.Open();

                    string sql = "SELECT UserId, UserName, UserPassword FROM User WHERE UserEmail=@email";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@email", email);
                    
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    
                    if (rdr.Read() && BC.Verify(password, rdr[2].ToString())){
                        NameAndId[0] = rdr[1].ToString();
                        NameAndId[1] = rdr[0].ToString();
                    }
                    rdr.Close();
                }
                catch (Exception ex){
                    Console.WriteLine(ex.ToString());
                }
            }
            
            return NameAndId;
        }
    }
}
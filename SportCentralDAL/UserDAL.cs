using SportCentralInterface;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralDAL
{
   public class UserDAL : IUser 
   {
        SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi479257;User=dbi479257;Password=Dagal555;");       
        public bool CreateUser(UserDTO userDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [User] (Username, Email, Password, Rank) VALUES (@Username, @Email, @Password, @Rank)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Username", userDTO.Username);
            sqlCommand.Parameters.AddWithValue("@Email", userDTO.Email);
            sqlCommand.Parameters.AddWithValue("@Name", userDTO.Username);
            sqlCommand.Parameters.AddWithValue("@Password", userDTO.Password);
            sqlCommand.Parameters.AddWithValue("@Rank", userDTO.Rank);
            sqlConnection.Open();
            SqlDataReader insert = sqlCommand.ExecuteReader();
            return true;
        }
        public bool CheckIfUserExist(UserDTO userDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Email = @Email", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", userDTO.Email);

            sqlConnection.Open();
            var result = sqlCommand.ExecuteReader();
            if (result.HasRows)
            {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public UserDTO GetUserByEmailAndPassword(string Email, string Password)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Email = @Email AND Password = @Password", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Password", Password);

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            // zet het resultaat in de reader
            UserDTO Result = new UserDTO();
            while (reader.Read())
            {

                Result.UserID = (int)reader["UserID"];
                Result.Email = (string)reader["Email"];
                Result.Username = (string)reader["Username"];
                Result.Password = (string)reader["Password"];
                Result.Rank = (int)reader["Rank"];
            }
            sqlConnection.Close();
            return Result;
        }
    }
}
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
            try
            {
                SqlDataReader insert = sqlCommand.ExecuteReader();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return true;
        }
        public bool UserExist(UserDTO userDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Email = @Email", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", userDTO.Email);
            sqlConnection.Open();

            try
            {
                var result = sqlCommand.ExecuteReader();
                if (result.HasRows)
                {
                    sqlConnection.Close();
                    return true;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
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
            UserDTO userDTO = new UserDTO();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userDTO.UserID = (int)reader["UserID"];
                    userDTO.Username = (string)reader["Username"];
                    userDTO.Email = (string)reader["Email"];
                    userDTO.Password = (string)reader["Password"];
                    userDTO.Rank = (int)reader["Rank"];
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            sqlConnection.Close();
            return userDTO;
        }

        public bool UserExistsByEmailAndPassword(string Email, string Password)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Email = @Email AND Password = @Password", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Password", Password);

            sqlConnection.Open();
            try
            {
                var result = sqlCommand.ExecuteReader();
                if (result.HasRows)
                {
                    sqlConnection.Close();
                    return true;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            sqlConnection.Close();
            return false;
        }
    }
}
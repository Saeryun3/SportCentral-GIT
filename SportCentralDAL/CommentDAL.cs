using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralDAL
{
    public class CommentDAL : IComment
    {
        SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi479257;User=dbi479257;Password=Dagal555;");
        public void CreateComment(CommentDTO commentDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Comment(CommentID, Text, DateTime, Rating ) VALUES(@CommentID, @Text, @DateTime, @Rating)", sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@CommentID", commentDTO.CommentID);
            sqlCommand.Parameters.AddWithValue("@Text", commentDTO.Text);
            sqlCommand.Parameters.AddWithValue("@DateTime", commentDTO.DateTime);
            sqlCommand.Parameters.AddWithValue("@Rating", commentDTO.Rating);
            try
            {
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            sqlConnection.Close();
        }

        public List<CommentDTO> GetAllComments(int newsID)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Comment WHERE NewsID = @newsId", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@newsId", newsID);
            sqlConnection.Open();
            List<CommentDTO> comments = new List<CommentDTO>();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    comments.Add(new CommentDTO()
                    {
                        CommentID = (int)reader["CommentID"],
                        Text = (string)reader["Text"],
                        //DateTime = (DateTime)reader["CommentID"],
                    });
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            sqlConnection.Close();
            return comments;
        }
    }
}

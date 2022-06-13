using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralDAL
{
    public class NewsDAL : INews
    {
        SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi479257;User=dbi479257;Password=Dagal555;");
        public bool CreateNews(NewsDTO newsDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO News(Title, Intro, Text, DateTime, Rating, Image, CategoryID) VALUES(@Title, @Intro, @Text, @DateTime, @Rating, @Image, @CategoryID)", sqlConnection);
            sqlConnection.Open();

            sqlCommand.Parameters.AddWithValue("@Title", newsDTO.Title);
            sqlCommand.Parameters.AddWithValue("@Intro", newsDTO.Intro);
            sqlCommand.Parameters.AddWithValue("@Text", newsDTO.Text);
            sqlCommand.Parameters.AddWithValue("@DateTime", newsDTO.Datetime);
            sqlCommand.Parameters.AddWithValue("@Rating", newsDTO.Rating);
            sqlCommand.Parameters.AddWithValue("@Image", newsDTO.Image);
            sqlCommand.Parameters.AddWithValue("@CategoryID", newsDTO.CategoryID);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            sqlConnection.Close();
            return true;
        }

        public void DeleteNews(int newsID)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM News WHERE NewsID = @NewsID", sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@NewsID", newsID);
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

        public List<NewsDTO> GetAllNews()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM News", sqlConnection);

            sqlConnection.Open();
            List<NewsDTO> Result = new List<NewsDTO>();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // zet het resultaat in de reader

                while (reader.Read())
                {
                    Result.Add(new NewsDTO()
                    {
                        NewsID = (int)reader["NewsID"],
                        Title = (string)reader["Title"],
                        Intro = (string)reader["Intro"],
                        Text = (string)reader["Text"],
                        Datetime = (DateTime)reader["Datetime"],
                        Rating = (int)reader["Rating"],
                        Image = (string)reader["Image"],
                    });
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            sqlConnection.Close();
            return Result;
        }

        public List<NewsDTO> GetAllNewsByCategory(int category)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM News WHERE CategoryID = @categoryId", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@categoryId", category);
            List<NewsDTO> Result = new List<NewsDTO>();
            sqlConnection.Open();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // zet het resultaat in de reader
                while (reader.Read())
                {
                    Result.Add(new NewsDTO()
                    {
                        NewsID = (int)reader["NewsID"],
                        Title = (string)reader["Title"],
                        Intro = (string)reader["Intro"],
                        Text = (string)reader["Text"],
                        Image = (string)reader["Image"],
                        Datetime = (DateTime)reader["Datetime"],
                        Rating = (int)reader["Rating"],
                    });
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            sqlConnection.Close();
            return Result;
        }

        public NewsDTO GetNewsByID(int ID)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM News WHERE NewsID = @NewsID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NewsID", ID);

            sqlConnection.Open();
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                // zet het resultaat in de reader

                while (reader.Read())
                {
                    NewsDTO newsDTO = new NewsDTO()
                    {
                        NewsID = (int)reader["NewsID"],
                        Title = (string)reader["Title"],
                        Intro = (string)reader["Intro"],
                        Text = (string)reader["Text"],
                        Image = (string)reader["Image"],
                        Datetime = (DateTime)reader["Datetime"],
                        Rating = (int)reader["Rating"],
                    };
                    return newsDTO;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            sqlConnection.Close();
            return null;
        }

        public void UpdateNews(NewsDTO news)
        {
            throw new NotImplementedException();
        }
    }
}
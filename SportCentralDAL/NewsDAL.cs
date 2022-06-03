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
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO News(Title, Intro, Text, DateTime, Rating, Image) VALUES(@Title, @Intro, @Text, @DateTime, @Rating, @Image)", sqlConnection);
            sqlConnection.Open();

            sqlCommand.Parameters.AddWithValue("@Title", newsDTO.Title);
            sqlCommand.Parameters.AddWithValue("@Intro", newsDTO.Intro);
            sqlCommand.Parameters.AddWithValue("@Text", newsDTO.Text);
            sqlCommand.Parameters.AddWithValue("@DateTime", newsDTO.Datetime);
            sqlCommand.Parameters.AddWithValue("@Rating", newsDTO.Rating);
            sqlCommand.Parameters.AddWithValue("@Image", newsDTO.Image);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public void DeleteNews(int newsID)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM News WHERE NewsID = @NewsID",sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@NewsID", newsID);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<NewsDTO> GetAllNews()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 6 * FROM News",sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            // zet het resultaat in de reader
            List<NewsDTO> Result = new List<NewsDTO>();

            while(reader.Read())
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
            sqlConnection.Close();
            return Result;
        }

        public List<NewsDTO> GetAllNewsByCategory(string categoryName)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM News JOIN Category on Category.CategoryID = News.CategoryID WHERE Category.CategoryName = @name", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", categoryName);

            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            // zet het resultaat in de reader
            List<NewsDTO> Result = new List<NewsDTO>();

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
            sqlConnection.Close();
            return Result;
        }

        public NewsDTO GetNewsByID(int ID)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM News WHERE NewsID = @NewsID",sqlConnection);

            sqlCommand.Parameters.AddWithValue("@NewsID", ID);
          
            sqlConnection.Open();
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
            sqlConnection.Close();
            return null;
        }

        public void UpdateNews(NewsDTO news)
        {
            throw new NotImplementedException();
        }
    }
}
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
        SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi479257;User Id=dbi479257;Password=Dagal555;");
        public void Addnews(NewsDTO newsDTO)
        {
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO News(Title, Intro, Text) VALUES(@Title, @Intro, @Text)", sqlConnection);
            sqlConnection.Open();

            sqlCommand.Parameters.AddWithValue("Title", newsDTO.Title);
            sqlCommand.Parameters.AddWithValue("Intro", newsDTO.Intro);
            sqlCommand.Parameters.AddWithValue("Text", newsDTO.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void UpdateNews(NewsDTO news)
        {
            throw new NotImplementedException();
        }
    }
}
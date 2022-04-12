using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralTest
{
    public class NewsContainerTestStub : INews
    {
        public List<NewsDTO> news = new List<NewsDTO>();

        public NewsContainerTestStub()
        {
            NewsDTO article = new NewsDTO()
            {
                NewsID = 1,
                Title = "Placeholder",
                Intro = "Placeholder",
                Text = "Placeholder",
                Datetime = DateTime.Now,
                Rating = true,
            };
            news.Add(article);
        }
        public void Addnews(NewsDTO newsDTO)
        {
            news.Add(newsDTO);
        }

        public List<NewsDTO> GetAllNews()
        {
            return news;
        }

        public void UpdateNews(NewsDTO news)
        {
            throw new NotImplementedException();
        }
    }
}

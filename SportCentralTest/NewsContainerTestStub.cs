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
                Rating = 1,
            };
            news.Add(article);
        }
        public bool Addnews(NewsDTO newsDTO)
        {
            news.Add(newsDTO);
            return true;
        }

        public void DeleteNews(int newsID)
        {
            for (int i = 0; i < news.Count; i++)
            {
                if (news[i].NewsID == newsID)
                {
                    news.Remove(news[i]);
                }
            } 
        }

        public List<NewsDTO> GetAllNews()
        {
            List<NewsDTO> newsDTOs = new List<NewsDTO>();
            foreach (NewsDTO newsDTO in news)
            {
               
            }
            return news;// to do
        }

        public List<NewsDTO> GetAllNewsByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public NewsDTO GetNewsByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateNews(NewsDTO news)
        {
            throw new NotImplementedException();
        }

        //bool INews.Addnews(NewsDTO newsDTO)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

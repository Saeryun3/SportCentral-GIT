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
            NewsDTO article1 = new NewsDTO()
            {
                NewsID = 1, 
                Title = "Placeholder",
                Intro = "Placeholder",
                Text = "Placeholder",
                Datetime = DateTime.Now,
                Rating = 1,
                CategoryID = 1
            };
        NewsDTO article2 = new NewsDTO()
        {
            NewsID = 2,
            Title = "Placeholders",
            Intro = "Placeholders",
            Text = "Placeholders",
            Datetime = DateTime.Now,
            Rating = 2,
            CategoryID = 2
            };

            news.Add(article1);
            news.Add(article2);
        }
        public bool CreateNews(NewsDTO newsDTO)
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
            return news;
        }

        public List<NewsDTO> GetAllNewsByCategory(int category)
        {
            List<NewsDTO> newsDTOs = new List<NewsDTO>();
            foreach (NewsDTO newsDto in news)
            {
                if (newsDto.CategoryID == category)
                {
                    newsDTOs.Add(newsDto);
                }
            }
            return newsDTOs;
        }

        public NewsDTO GetNewsByID(int ID)
        {
            foreach (NewsDTO newsDTO  in news)
            {
                if (newsDTO.NewsID == ID)
                {
                    return newsDTO;
                }
            }
            return null;
        }
    }
}

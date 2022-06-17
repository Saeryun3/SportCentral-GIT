using SportCentralInterface;
using SportCentralLibLogic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class NewsContainer
    {
        //private List<News> _newsList = new List<News>();
        private INews News;
        public NewsContainer(INews inews)
        {
            this.News = inews;
        }
        public void CreateNews(News news)
        {
            NewsDTO newsDTO = NewsConvertor.ConvertNewstoNewsDTO(news);
            News.CreateNews(newsDTO);
            //textbox toevoegen vooe image
            //voor afbeelding in convertor 
        }

        public List<News> GetAllNews()
        {
            List<NewsDTO> newsDTOs = News.GetAllNews();
            List<News> news = new List<News>();
            foreach (NewsDTO newsDTO in newsDTOs)
            {
                news.Add(new News(newsDTO));
            }
            return news;
        }

        public List<News> GetAllNewsByCategory(int category)
        {            
            List<NewsDTO> newsDTOs = News.GetAllNewsByCategory(category);
            List<News> news = new List<News>();
            foreach (NewsDTO newsDTO in newsDTOs)
            {
                news.Add(new News(newsDTO));
            }
            return news;
        }
        public News GetNewsByID(int ID)
        {
            NewsDTO newsDTOs = News.GetNewsByID(ID);
            News news = new News(newsDTOs);
            return news;
        }

        public void DeleteNews(int newsID)
        {
            News.DeleteNews(newsID);
        }     
    }
}

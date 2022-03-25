using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class NewsContainer
    {
        private List<News> _newsList = new List<News>();
        public void Addnews(News news)
        {
            if (_newsList.Contains(news))
            {
                throw new ArgumentException("Can not add duplicate news");
            }

            if (string.IsNullOrWhiteSpace(news.Title) || string.IsNullOrWhiteSpace(news.Intro))
            {
                throw new ArgumentException("Can not publish without title or intro");
            }
            _newsList.Add(news);
        }

        public void UpdateNews(News news)
        {
            // insert into (list) and remove
        }

        public IReadOnlyCollection<News> GetAllNews()
        {
            return _newsList;
        }          


    }
}

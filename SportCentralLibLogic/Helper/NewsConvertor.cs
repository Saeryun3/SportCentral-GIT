using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic.Helper
{
   public class NewsConvertor
   {
        public static NewsDTO ConvertNewstoNewsDTO(News news)
        {
            NewsDTO newsDTO = new NewsDTO();
            newsDTO.NewsID = news.NewsID;
            newsDTO.Title = news.Title;
            newsDTO.Intro = news.Intro;
            newsDTO.Text = news.Text;
            newsDTO.Datetime = news.Datetime;
            newsDTO.Rating = news.Rating;
            newsDTO.Image = news.Image;
            return newsDTO;
        }
   }
}

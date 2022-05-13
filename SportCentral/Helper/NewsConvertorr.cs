using SportCentral.Models;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Helper
{
    public class NewsConvertorr
    {
        public static News ConvertToNews(NewsViewModel nvm)
        {
            News news = new News();
            news.Title = nvm.Title;
            news.Intro = nvm.Intro;
            news.Text = nvm.Text;
            news.Image = nvm.Image;
            news.Datetime = nvm.Datetime;
            news.Rating = nvm.Rating;
            return news;
        }
    }
}

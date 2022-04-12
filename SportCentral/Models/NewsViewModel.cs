using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Models
{
    public class NewsViewModel
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }

        public NewsViewModel()
        {

        }

        public NewsViewModel(News news)
        {
            NewsID = news.NewsID;
            Title = news.Title;
            Intro = news.Intro;
            Text = news.Text;
            Datetime = news.Datetime;
            Rating = news.Rating;
        }
    }
}

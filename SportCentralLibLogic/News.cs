using SportCentralInterface;
using System;

namespace SportCentralLibLogic
{
    public class News
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }

        public News(string title, string intro, string text,string image, DateTime datetime, int rating)
        {
            NewsID = NewsID;
            Title = title;
            Intro = intro;
            Text = text;
            Image = image;
            Datetime = datetime; 
            Rating = rating;
        }
        public News(NewsDTO newsDTO)
        {
            NewsID = newsDTO.NewsID;
            Title = newsDTO.Title;
            Intro = newsDTO.Intro;
            Text = newsDTO.Text;
            Image = newsDTO.Image;
            Datetime = newsDTO.Datetime;
            Rating = newsDTO.Rating;
        }
        public News()
        {

        }
    }
}

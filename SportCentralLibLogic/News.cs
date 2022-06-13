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
        public int CategoryID { get; set; }

        public News(int newsID, string title, string intro, string text,string image, DateTime datetime, int rating, int categoryID)
        {
            NewsID = newsID;
            Title = title;
            Intro = intro;
            Text = text;
            Image = image;
            Datetime = datetime; 
            Rating = rating;
            CategoryID = categoryID;
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
            CategoryID = newsDTO.CategoryID;
        }
        public News()
        {

        }
    }
}

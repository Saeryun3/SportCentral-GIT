using System;

namespace SportCentralLibLogic
{
    public class News
    {
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }

        public News(string title, string intro, string text, DateTime datetime, int rating)
        {
            Title = title;
            Intro = intro;
            Text = text;
            Datetime = datetime; 
            Rating = rating;
        }
        public News()
        {

        }
    }
}

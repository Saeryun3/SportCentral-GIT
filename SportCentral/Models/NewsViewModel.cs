using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Models
{
    public class NewsViewModel
    {
        public int NewsID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Intro { get; set; }
        public string Text { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime Datetime { get; set; }
        public int Rating { get; set; }
        public List <CommentViewModel> comments = new List<CommentViewModel>();

        public NewsViewModel()
        {

        }

        public NewsViewModel(News news)
        {
            NewsID = news.NewsID;
            Title = news.Title;
            Intro = news.Intro;
            Text = news.Text;
            Image = news.Image;
            Datetime = news.Datetime;
            Rating = news.Rating;
        }
    }
}

using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Models
{
    public class CommentViewModel
    {
        public int CommentID { get; set; }
        public string Text { get;  set; }
        public DateTime DateTime { get;  set; }
        public bool Rating { get;  set; }
        public int NewsID { get; set; }
        public string UserName { get; set; }
        public CommentViewModel(Comment comment, string userName)
        { 
            CommentID = comment.CommentID;
            Text = comment.Text;
            DateTime = comment.Datetime;
            Rating = comment.Rating;
            UserName = userName;
        }

        public CommentViewModel()
        {
                
        }
    }
}

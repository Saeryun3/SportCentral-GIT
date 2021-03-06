using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Text { get;  set; }
        public DateTime Datetime { get;  set; }
        public bool Rating { get;  set; }
        public int NewsID { get; set; }
        public int UserID { get; set; }

        public Comment(int commentID, string text, DateTime date, bool rating, int newsID, int userID)
        {
            CommentID = commentID;
            Text = text;
            Datetime = date;
            Rating = rating;
            NewsID = newsID;
            UserID = userID;
        }

        public Comment(CommentDTO comment)
        {
            CommentID = comment.CommentID;
            Text = comment.Text;
            Datetime = comment.DateTime;
            Rating = comment.Rating;
            NewsID = comment.NewsID;
            UserID = comment.UserID;
        }

        public Comment()
        {

        }

    }
}

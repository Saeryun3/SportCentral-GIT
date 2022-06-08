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
        public string Text { get; private set; }
        public DateTime DateTime { get;  set; }
        public bool Rating { get;  set; }

        public Comment(int reactID, string text, DateTime date, bool rating)
        {
            CommentID = reactID;
            Text = text;
            DateTime = date;
            Rating = rating;
        }

        public Comment(CommentDTO comment)
        {
            CommentID = comment.CommentID;
            Text = comment.Text;
            DateTime = comment.DateTime;
            Rating = comment.Rating;
        }

    }
}

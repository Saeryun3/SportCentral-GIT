using SportCentral.Models;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportCentral.Helper
{
    public class CommentConvertorr
    {
        public static Comment ConvertToComment(CommentViewModel cvm)
        {
            Comment comment = new Comment();
            comment.CommentID = cvm.CommentID;
            comment.Text = cvm.Text;
            comment.Datetime = cvm.DateTime;
            comment.Rating = cvm.Rating;
            comment.NewsID = cvm.NewsID;
            return comment;

        }
    }
}

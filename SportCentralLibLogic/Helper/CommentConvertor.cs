using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic.Helper
{
    public class CommentConvertor
    {
        public static CommentDTO ConvertReactToReactDTO(Comment comment)
        {
            CommentDTO commentDTO = new CommentDTO();
            commentDTO.CommentID = comment.CommentID;
            commentDTO.Text = comment.Text;
            commentDTO.DateTime = comment.DateTime;
            commentDTO.Rating = comment.Rating;
            return commentDTO;
        }
    }
}

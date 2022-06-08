using SportCentralInterface;
using SportCentralLibLogic.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralLibLogic
{
    public class CommentContainer
    {
        private IComment Comments;
        public CommentContainer(IComment icomment)
        {
            this.Comments = icomment;
        }

        public List<Comment> GetAllComments(int newsID)
        {
            List<CommentDTO> commentDTOs = Comments.GetAllComments(newsID);
            List<Comment> comments = new List<Comment>();
            foreach (CommentDTO commentDTO in commentDTOs)
            {
                comments.Add(new Comment(commentDTO));
            }
            return comments;
        }

        public void CreateComment(Comment comment)
        {
            CommentDTO reactDTO = CommentConvertor.ConvertReactToReactDTO(comment);
            Comments.CreateComment(reactDTO); 
        }

        public bool Rate(Comment comment)
        {
            return true;
        }
    }
}

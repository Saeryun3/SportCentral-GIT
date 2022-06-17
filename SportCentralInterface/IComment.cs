using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public interface IComment
    {
        void CreateComment(CommentDTO commentDTO);
        List<CommentDTO> GetAllComments(int newsID);
        void DeleteComment(int commentID);
    }
}

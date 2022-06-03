using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralInterface
{
    public interface IComment
    {
        void CreateComment(CommentDTO reactDTO);
        List<CommentDTO> GetAllComments();
    }
}

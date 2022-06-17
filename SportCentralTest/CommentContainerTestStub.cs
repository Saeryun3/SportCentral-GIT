using SportCentralInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralTest
{
    public class CommentContainerTestStub : IComment
    {
        public List<CommentDTO> comments = new List<CommentDTO>();
        public CommentContainerTestStub()
        {
            CommentDTO commentDTO1 = new CommentDTO()
            {
                CommentID = 1,
                Text = "Placeholder",
                DateTime = DateTime.Now,
                Rating = true,
                NewsID = 1,
            };
            
            CommentDTO commentDTO2 = new CommentDTO()
            {
                CommentID = 2,
                Text = "Placeholders",
                DateTime = DateTime.Now,
                Rating = true,
                NewsID = 2,
            };
            CommentDTO commentDTO3 = new CommentDTO()
            {
                CommentID = 3,
                Text = "Placeholders",
                DateTime = DateTime.Now,
                Rating = true,
                NewsID = 2,
            };
            comments.Add(commentDTO1);
            comments.Add(commentDTO2);
            comments.Add(commentDTO3);
        }

        public void CreateComment(CommentDTO commentDTO)
        {
            comments.Add(commentDTO);
        }

        public void DeleteComment(int commentID)
        {
            foreach (var comment in comments)
            {
                comments.Remove(comment);
            }
        }

        public List<CommentDTO> GetAllComments(int newsID)
        {
            List<CommentDTO> CommentDTOs = new List<CommentDTO>();
            foreach (CommentDTO commentDTO in comments)
            {
                if (commentDTO.NewsID == newsID)
                {
                    CommentDTOs.Add(commentDTO);
                }
            }
            return CommentDTOs;
        }
    }
}

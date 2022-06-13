using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralTest
{
    [TestClass]
    public class CommentContainerTest
    {
        [TestMethod]
        public void CreateCommentTest()
        {
            //arange
            CommentContainerTestStub commentContainerTestStub = new CommentContainerTestStub();
            CommentContainer commentContainer = new CommentContainer(commentContainerTestStub);
            Comment comment = new Comment()
            {
                CommentID = 3,
                Text = "Placeholder3",
                DateTime = DateTime.Now,
                Rating = true,
            };
            //act
            commentContainer.CreateComment(comment);
            //assert
            Assert.AreEqual(3, commentContainerTestStub.comments.Count);
            Assert.AreEqual(comment.CommentID, commentContainerTestStub.comments[2].CommentID);
            Assert.AreEqual(comment.Text, commentContainerTestStub.comments[2].Text);
            Assert.AreEqual(comment.DateTime, commentContainerTestStub.comments[2].DateTime);
            Assert.AreEqual(comment.Rating, commentContainerTestStub.comments[2].Rating);
        }

        [TestMethod]
        public void GetAllCommentsTest()// by newsid
        {
            //arange
            CommentContainerTestStub commentContainerTestStub = new CommentContainerTestStub();
            CommentContainer commentContainer = new CommentContainer(commentContainerTestStub);
            //act
            List<Comment> comments = commentContainer.GetAllComments(1);
            //assert
            Assert.AreEqual(1, comments.Count);
        }

    }
}

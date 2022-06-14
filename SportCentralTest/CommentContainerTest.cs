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
                Datetime = DateTime.Now,
                Rating = true,
            };
            var expectedamount = commentContainerTestStub.comments.Count + 1;
            //act
            commentContainer.CreateComment(comment);
            //assert
            Assert.AreEqual(expectedamount, commentContainerTestStub.comments.Count);
            Assert.AreEqual(comment.CommentID, commentContainerTestStub.comments[expectedamount - 1].CommentID);
            Assert.AreEqual(comment.Text, commentContainerTestStub.comments[expectedamount - 1].Text);
            Assert.AreEqual(comment.Datetime, commentContainerTestStub.comments[expectedamount - 1].DateTime);
            Assert.AreEqual(comment.Rating, commentContainerTestStub.comments[expectedamount - 1].Rating);
        }

        [TestMethod]
        public void GetAllCommentsTest()//newsid
        {
            //arange
            CommentContainerTestStub commentContainerTestStub = new CommentContainerTestStub();
            CommentContainer commentContainer = new CommentContainer(commentContainerTestStub);
            var comment1 = commentContainerTestStub.comments[0];
            int expectedamount = 0;
            foreach (var comment in commentContainerTestStub.comments)
            {
                if (comment1.NewsID == comment.NewsID)
                {
                    expectedamount++;
                }
            }
            //act
            List<Comment> comments = commentContainer.GetAllComments(comment1.NewsID);
            //assert
            Assert.AreEqual(expectedamount, comments.Count); 
        }

    }
}

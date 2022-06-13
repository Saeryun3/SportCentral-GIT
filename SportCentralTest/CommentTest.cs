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
    public class CommentTest
    {
        [TestMethod]
        public void ConstructorReactTest()
        {
            //arrange
            var commentID = 1;
            var text = "Placeholder";
            var rating = true;
            DateTime datetime = new DateTime(2021, 02, 21);
            var newsID = 1;
            //act
            var comment = new Comment(commentID, text, datetime, rating, newsID);
            //assert
            Assert.IsTrue(comment.CommentID == commentID && comment.Text == text && comment.DateTime == datetime && comment.Rating == rating && comment.NewsID == newsID);
        }
    }
} 

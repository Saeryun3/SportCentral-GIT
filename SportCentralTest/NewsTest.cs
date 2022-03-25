using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SportCentralLibLogic;

namespace SportCentralTest
{
    [TestClass]
    public class NewsTest
    {
        [TestMethod]
        public void ConstructorNewsTest()
        {
            //arrange
            var title = "Placeholder";
            var intro = "Placeholer intro";
            var text = "Placeholder text";
            var rating = 1;
            DateTime datetime = new DateTime(2021, 12, 13);
            //act
            var news = new News(title, intro, text, datetime, rating);
            //assert
            Assert.IsTrue(news.Title == title && news.Intro == intro && news.Text == text && news.Datetime == datetime && news.Rating == rating);
        }
        // classes constructors
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SportCentralLibLogic;

namespace SportCentralTest
{
    [TestClass]
    public class NewsTest
    {
        [TestMethod]
        public void CreateNewsTest()
        {
            //arrange
            var title = "Placeholder";
            var intro = "Placeholer intro";
            var text = "Placeholder text";
            int rating = 0;
            DateTime datetime = new DateTime(2021, 12, 13);
            var image = "placeholder image";
            //act
            var news = new News(title, intro, text, image, datetime, rating);
            //assert
            Assert.IsTrue(news.Title == title && news.Intro == intro && news.Text == text && news.Datetime == datetime && news.Rating == rating);
        }        
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportCentralLibLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCentralTest
{
    [TestClass]
    public class NewsContainerTest
    {
        [TestMethod]
        public void AddNewsTest()
        {
            //arrange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            News news = new News()
            {
                NewsID = 3,
                Title = "Placeholder",
                Intro = "Placeholder",
                Text = "Placeholder",
                Datetime = DateTime.Now,
                Rating = true,
            };
            List<News> newsList = new List<News>();
            //act
            newsContainer.Addnews(news);
            ///*var result*/ newsList = newsContainer.GetAllNews();
            //var result = newsList.Contains(news);
            //assert
            Assert.AreEqual(2, newsContainerTestStub.news.Count);
          //  Assert.AreEqual();
        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
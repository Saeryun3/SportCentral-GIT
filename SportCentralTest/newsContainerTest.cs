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
    public class NewsContainerTest
    {
        [TestMethod]
        public void CreateNewsTest()
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
                Rating = 1,
                Image = "Placeholder"
            };
            List<News> newsList = new List<News>();
            //act
            newsContainer.CreateNews(news);
            //assert
            Assert.AreEqual(3, newsContainerTestStub.news.Count);
            Assert.AreEqual(news.NewsID, newsContainerTestStub.news[2].NewsID);
            Assert.AreEqual(news.Title, newsContainerTestStub.news[2].Title);
            Assert.AreEqual(news.Intro, newsContainerTestStub.news[2].Intro);
            Assert.AreEqual(news.Text, newsContainerTestStub.news[2].Text);
            Assert.AreEqual(news.Datetime, newsContainerTestStub.news[2].Datetime);
            Assert.AreEqual(news.Rating, newsContainerTestStub.news[2].Rating);
            Assert.AreEqual(news.Image, newsContainerTestStub.news[2].Image);
        }

        [TestMethod]
        public void DeleteNewsTest()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            //act
            newsContainer.DeleteNews(2);
            //assert
            Assert.AreEqual(1, newsContainerTestStub.news.Count);
        }

        [TestMethod]
        public void GetAllNewsTest()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            //act
            List<News> news = newsContainer.GetAllNews();
            // assert
            Assert.AreEqual(2, news.Count);
        }
        [TestMethod]
        public void GetAllNewsByCategory()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            //act
            List<News> news = newsContainer.GetAllNewsByCategory(1);
            //assert
            Assert.AreEqual(1, news.Count);
        }

        [TestMethod]
        public void GetNewsByIDTest()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            //act
            News news = newsContainer.GetNewsByID(1);
            //assert
            Assert.AreEqual(news.NewsID, newsContainerTestStub.news[0].NewsID);
            Assert.AreEqual(news.Title, newsContainerTestStub.news[0].Title);
            Assert.AreEqual(news.Intro, newsContainerTestStub.news[0].Intro);
            Assert.AreEqual(news.Text, newsContainerTestStub.news[0].Text);
            Assert.AreEqual(news.Datetime, newsContainerTestStub.news[0].Datetime);
            Assert.AreEqual(news.Rating, newsContainerTestStub.news[0].Rating);
            Assert.AreEqual(news.Image, newsContainerTestStub.news[0].Image);
        }
    }
}

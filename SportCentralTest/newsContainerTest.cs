using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportCentralInterface;
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
    { // probeer zonder aanpassingen
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
            var expectedamount = newsContainerTestStub.GetAllNews().Count + 1;
            //act
            newsContainer.CreateNews(news);
            //assert
            Assert.AreEqual(expectedamount, newsContainerTestStub.GetAllNews().Count);
            Assert.AreEqual(news.NewsID, newsContainerTestStub.news[expectedamount -1].NewsID);
            Assert.AreEqual(news.Title, newsContainerTestStub.news[expectedamount - 1].Title);
            Assert.AreEqual(news.Intro, newsContainerTestStub.news[expectedamount - 1].Intro);
            Assert.AreEqual(news.Text, newsContainerTestStub.news[expectedamount - 1].Text);
            Assert.AreEqual(news.Datetime, newsContainerTestStub.news[expectedamount - 1].Datetime);
            Assert.AreEqual(news.Rating, newsContainerTestStub.news[expectedamount - 1].Rating);
            Assert.AreEqual(news.Image, newsContainerTestStub.news[expectedamount - 1].Image);
        }

        [TestMethod]
        public void DeleteNewsTest()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            var newslist = newsContainer.GetAllNews();
            var deletenews = newslist[0];
            //act
            newsContainer.DeleteNews(deletenews.NewsID);            
            //assert
            Assert.AreEqual(newslist.Count - 1, newsContainerTestStub.news.Count);
            foreach (var news in newsContainerTestStub.news)
            {
                Assert.IsFalse(news.NewsID == deletenews.NewsID);
            }
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
            Assert.AreEqual(newsContainerTestStub.GetAllNews().Count, news.Count);// total news
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
            Assert.AreEqual(newsContainerTestStub.GetAllNewsByCategory(1).Count , news.Count);
        }

        [TestMethod]
        public void GetNewsByIDTest()
        {
            //arange
            NewsContainerTestStub newsContainerTestStub = new NewsContainerTestStub();
            NewsContainer newsContainer = new NewsContainer(newsContainerTestStub);
            var getnews = newsContainerTestStub.GetAllNews()[0];
            //act
            News news = newsContainer.GetNewsByID(getnews.NewsID);
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

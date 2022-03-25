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
        public void AddNewsTest()
        {
            //arrange
            var newscontainer = new NewsContainer();
            var news = new News("placeholder", "Placeholder", "placeholder", DateTime.Now, 5);
            //act
            newscontainer.Addnews(news);
            //assert
            Assert.IsTrue(newscontainer.GetAllNews().Contains(news));
            
        }
    }
 
}

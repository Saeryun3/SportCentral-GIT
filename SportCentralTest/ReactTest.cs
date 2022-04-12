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
    public class ReactTest
    {
        [TestMethod]
        public void ConstructorReactTest()
        {
            //arrange
            var text = "Placeholder";
            var rating = true;
            DateTime datetime = new DateTime(2021, 02, 21);
            //act
            var react = new React(text, datetime, rating);
            //assert
            Assert.IsTrue(react.Text == text && react.DateTime == datetime && react.Rating == rating);
        }
    }
} 

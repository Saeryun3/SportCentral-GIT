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
   public  class UserContainerTest
    {
        [TestMethod]
        public void TestCreateUser()
        {
            //arange
            UserContainerTestStub userContainerTestStub = new UserContainerTestStub();
            UserContainer userContainer = new UserContainer(userContainerTestStub);
            User user = new User()
            {
                UserID = 3,
                Username = "PlaceNames",
                Email = "holders@gmail.com",
                Password = "PlacePasswordss",
                Rank = (int)Rank.User
            };
            var expectedamount = userContainerTestStub.users.Count + 1;
            //act            
            userContainer.CreateUser(user);
            //assert
            Assert.AreEqual(expectedamount, userContainerTestStub.users.Count);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[expectedamount -1].UserID);
            Assert.AreEqual(user.Username, userContainerTestStub.users[expectedamount - 1].Username);
            Assert.AreEqual(user.Password, userContainerTestStub.users[expectedamount - 1].Password);
            Assert.AreEqual((int)user.Rank, userContainerTestStub.users[expectedamount - 1].Rank);
        }
        [TestMethod]
        public void UserExistTest()
        {
            //arange
            UserContainerTestStub userContainerTestStub = new UserContainerTestStub();
            UserContainer userContainer = new UserContainer(userContainerTestStub);
            User user = new User()
            {
                UserID = 3,
                Username = "PlaceNames",
                Email = "holders@gmail.com",
                Password = "PlacePasswordss",
                Rank = (int)Rank.User
            };
            //act
            var result = userContainer.UserExist(user);
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UserExistsByEmailAndPasswordTest()
        {
            //arange 
            UserContainerTestStub userContainerTestStub = new UserContainerTestStub();
            UserContainer userContainer = new UserContainer(userContainerTestStub);
            User user = new User()
            {
                UserID = 1,
                Username = "PlaceName",
                Email = "Placeholder@gmail.com",
                Password = "PlacePassword",
                Rank = (int)Rank.User
            };
            //act
            var result = userContainer.UserExistsByEmailAndPassword(user);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void getUserByIDTest()
        {
            //arange
            UserContainerTestStub userContainerTestStub = new UserContainerTestStub();
            UserContainer userContainer = new UserContainer(userContainerTestStub);
            User user = new User()
            {
                UserID = 1,
                Username = "PlaceName",
                Email = "Placeholder@gmail.com",
                Password = "PlacePassword",
                Rank = (int)Rank.User
            };
            //act
            var result = userContainer.GetUserByID(1);
            //assert
            Assert.AreEqual(result, "PlaceName");
        }
    }
}

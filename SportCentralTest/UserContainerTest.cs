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
            //act            
            userContainer.CreateUser(user);
            //assert
            Assert.AreEqual(3, userContainerTestStub.users.Count);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
            Assert.AreEqual(user.UserID, userContainerTestStub.users[2].UserID);
        }
        [TestMethod]
        public void CheckIfUserExitTest()
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
            var result = userContainer.CheckIfUserExist(user);
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetPlayerByEmailAndPasswordTest()
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
            User user1 = userContainer.GetUserByEmailAndPassword(user.Email, user.Password);
            //assert
            Assert.AreEqual(user.UserID, user1.UserID);
        }

    }
}

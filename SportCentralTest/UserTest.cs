using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportCentralLibLogic;
using System;


namespace SportCentralTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CreateUsertest()
        {
            //arange
            int userID = 1;
            var username = "Sam";
            var email = "S@mail.com";
            var password = "1234";
            Rank rank = Rank.User;
            //act
            var user = new User(userID, username, email, password, rank);
            //assert
            Assert.IsTrue(user.UserID == userID && user.Username == username && user.Email == email && user.Password == password && user.Rank == Rank.User);
        }
    }
}

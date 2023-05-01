using coderview_API.Service;
using Entities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Diagnostics;

namespace TestProject
{
    [TestClass]
    public class UserItemTest
    {
        [TestMethod]
        public void ValidateUserTest()
        {
            //Arrange
            var userA = new UserItem();
            userA.Id = 3;
            userA.UserName = " Betzaida";
            userA.LastName = "Coy";
            userA.Email = "";
            userA.InsertDate = DateTime.Now.AddDays(-1);
            //userA.UpdateDate = DateTime.Now;

            var userB = new UserItem();
            userB.Id = 3;
            userB.UserName = "Diana";
            userB.LastName = "Romero";
            userB.Email = "Diana.romecoy@gmail.com";
            userB.InsertDate = DateTime.Now.AddDays(-1);
            //userB.UpdateDate = DateTime.Now;

            var userC = new UserItem();
            userC.Id = 3;
            userC.UserName = "Diana";
            userC.LastName = "Romero";
            userC.Email = "Diana.romecoy@gmail.com";
            userC.InsertDate = DateTime.Now.AddDays(-1);
            //userC.UpdateDate = DateTime.Now;


            //Act
            var isValidA = UserService.ValidateUser(userA);
            var isValidB = UserService.ValidateUser(userB);
            var isValidC = UserService.ValidateUser(userC);


            //Assert

            Assert.AreEqual(false, isValidA, "El testede modelo de UserA ha fallado.");
            Assert.AreEqual(true, isValidB, "Custom error message");
            Assert.AreEqual(true, isValidC, "Custom error message");


        }
    }
    
}
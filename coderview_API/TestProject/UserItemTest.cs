using Entities;
using Logic.Logic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace TestProject
{
    [TestClass]
    public class UserItemTest
    {
        public readonly UserLogic _userLogic;
        [TestMethod]
        public void UserItem_Constructor_IsActiveTrue()
        {
            // Arrange
            var userItem = new UserItem();

            // Act

            // Assert
            Assert.IsTrue(userItem.IsActive);
        }

        [TestMethod]
        public void UserItem_SetAndGetProperties()
        {
            // Arrange
            var userItem = new UserItem();
            var expectedUserName = "Diana";
            var expectedLastName = "Romero";
            var expectedEmail = "diana.romecoy@gmail.com";
            var expectedInsertDate = new DateTime(2023, 1, 1);
            var expectedUpdateDate = new DateTime(2023, 1, 1);

            // Act
            userItem.UserName = expectedUserName;
            userItem.LastName = expectedLastName;
            userItem.Email = expectedEmail;
            userItem.InsertDate = expectedInsertDate;
            userItem.UpdateDate = expectedUpdateDate;

            // Assert
            Assert.AreEqual(expectedUserName, userItem.UserName);
            Assert.AreEqual(expectedLastName, userItem.LastName);
            Assert.AreEqual(expectedEmail, userItem.Email);
            Assert.AreEqual(expectedInsertDate, userItem.InsertDate);
            Assert.AreEqual(expectedUpdateDate, userItem.UpdateDate);
        }

        [TestMethod]

        public void UserItem_ConfirmEncryptedPassword_IsNotMappedToDatabase()
        {
            // Arrange
            var userItem = new UserItem();
            var expectedConfirmPassword = "mypassword";

            // Act
            userItem.ConfirmPassword = expectedConfirmPassword;

            // Assert
            Assert.IsNull(userItem.GetType().GetProperty("ConfirmPassword").GetCustomAttributes(typeof(ColumnAttribute), true).FirstOrDefault());
            Assert.AreEqual(expectedConfirmPassword, userItem.ConfirmPassword);
        }








        //// public void UserItem_UserNameAndEmail_PropertiesSetAndGetCorrectly()
        //// {
        //     //Arrange indica el espacio de inicializar las variables

        //     //var expectedUserName = "Diana ";

        //     //var expectedEmail = "diana.romecoy@gmil.com";

        //     //var userItem = new UserItem();

        //     //var expectedPassword = "mypassword";


        //     //Act donde llamamos al servicio que vamos a ejecutar

        //     userItem.UserName = expectedUserName;
        //     userItem.Email = expectedEmail;
        //    // userItem.ConfirmPassword= expectedPassword;


        //     // Assert resultado que nos ha devuelto el método es el esperado
        //     Assert.AreEqual(expectedUserName, userItem.UserName);
        //     Assert.AreEqual(expectedEmail, userItem.Email);
        //     //Assert.IsNull(userItem.GetType().GetProperty("ConfirmPassword").GetCustomAttribute(typeof(ColumnAttribute).FirsOrDefault()));
        //     //Assert.AreEqual(expectedPassword, userItem.ConfirmPassword);


    }
}

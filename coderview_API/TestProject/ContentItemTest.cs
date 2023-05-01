using coderview_API.Service;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class ContentItemTest
    {
        [TestMethod]

        public void ValidateContentItemTest()
        {
            //Arrange
            var conetentA = new ContentItem();
            conetentA.Id = 1;
            conetentA.Title = "Test";
            conetentA.SkillId = 1;

            var conetentB = new ContentItem();
            conetentB.Id = 2;
            conetentB.Title = "Test";
            conetentB.SkillId = 2;


            var conetentC = new ContentItem();
            conetentC.Id = 3;
            conetentC.Title = "Test";
            conetentC.SkillId = 3;

            //Act
            var isValidA = ContentService.ValidateContent(conetentA);
            var isValidB = ContentService.ValidateContent(conetentB);
            var isValidC = ContentService.ValidateContent(conetentC);

            //Assert

            Assert.AreEqual(true, isValidA,"" );
            Assert.AreEqual(true, isValidB, "");
            Assert.AreEqual(true, isValidC, "");

        }
    }
}


      

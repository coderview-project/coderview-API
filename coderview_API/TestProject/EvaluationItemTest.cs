using Entities;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class EvaluationItemTest
    {
        public readonly EvaluationLogic _evaluationLogic;
        [TestMethod]
        public void EvaluationItemConstructor_ShouldSetIsActiveToTrue()
        {
            // Arrange
            var evaluationItem = new EvaluationItem();

            // Act

            // Assert
            Assert.IsTrue(evaluationItem.IsActive);
        }

        [TestMethod]
        public void EvaluationItemSettersAndGetters_ShouldWorkAsExpected()
        {
            // Arrange
            var evaluationItem = new EvaluationItem();
            evaluationItem.Id = 1;
            evaluationItem.TypeId = 2;
            evaluationItem.UserId = 3;
            evaluationItem.EvaluateeUserId = 4;
            evaluationItem.StateId = 5;
            evaluationItem.ValueId = 6;
            //evaluationItem.ContentId = 7;
            evaluationItem.StartDate = DateTime.Now;
            evaluationItem.FinishDate = DateTime.Now.AddDays(1);
            evaluationItem.IsActive = false;

            // Act

            // Assert
            Assert.AreEqual(1, evaluationItem.Id);
            Assert.AreEqual(2, evaluationItem.TypeId);
            Assert.AreEqual(3, evaluationItem.UserId);
            Assert.AreEqual(4, evaluationItem.EvaluateeUserId);
            Assert.AreEqual(5, evaluationItem.StateId);
            Assert.AreEqual(6, evaluationItem.ValueId);
            //Assert.AreEqual(7, evaluationItem.ContentId);
            Assert.IsFalse(evaluationItem.IsActive);
        }
    }
}
    


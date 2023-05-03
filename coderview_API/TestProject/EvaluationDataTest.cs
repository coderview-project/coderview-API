
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
    internal class EvaluationDataTest
    {               
        [TestMethod]
        public void ValidateEvaluationDataTest()
        {
            //Arrange
            var DataA = new EvaluationData();
            DataA.Id = 1;
            DataA.ProjectM = 5;
            DataA.FuncTech1 = 5;
            DataA.FuncTech2 = 4;
            DataA.FuncTech3 = 6;
            DataA.Front1 = 3;
            DataA.Front2 = 4;
            DataA.Back1 = 4;
            DataA.Back2 = 5;
            DataA.Archit = 3;
            DataA.Qa1 = 3;
            DataA.Qa2 = 5;
            DataA.Qa3 = 6;
            DataA.EvaluatorId = 5;
            DataA.EvaluateeId = 5;
            DataA.EvaluationId = 3;

            var DataB = new EvaluationData();
            DataB.Id = 2;
            DataB.ProjectM = 4;
            DataB.FuncTech1 =4;
            DataB.FuncTech2 = 3;
            DataB.FuncTech3 = 6;
            DataB.Front1 = 5;
            DataB.Front2 = 6;
            DataB.Back1 = 3;
            DataB.Back2 = 4;
            DataB.Archit = 3;
            DataB.Qa1 = 5;
            DataB.Qa2 = 6;
            DataB.Qa3 = 4;
            DataB.EvaluatorId = 6;
            DataB.EvaluateeId = 5;
            DataB.EvaluationId = 4;

            var DataC = new EvaluationData();
            DataC.Id = 0;
            DataC.ProjectM = 1;
            DataC.FuncTech1 = 4;
            DataC.FuncTech2 = 3;
            DataC.FuncTech3 = 5;
            DataC.Front1 = 5;
            DataC.Front2 = 6;
            DataC.Back1 = 5;
            DataC.Back2 = 0;
            DataC.Archit = 4;
            DataC.Qa1 = 5;
            DataC.Qa2 = 6;
            DataC.Qa3 = 4;
            DataC.EvaluatorId = 6;
            DataC.EvaluateeId = 5;
            DataC.EvaluationId = 5;


            //Act
            var isValidA = EvaluationDataService.ValidateEvaluetionData(DataA);
            var isValidB = EvaluationDataService.ValidateEvaluetionData(DataB);
            var isValidC = EvaluationDataService.ValidateInsertEvaluationData(DataC);


            //Assert

            Assert.AreEqual(true, isValidA, "El testede modelo de evaluetionDataA ha fallado.");
            Assert.AreEqual(true, isValidB, "Ocurrio un error message");
            Assert.AreEqual(false, isValidC, "Custom error message");

        }
    }
}

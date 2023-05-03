
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
            var evaluationDataA = new EvaluationData();
            evaluationDataA.Id = 1;
            evaluationDataA.ProjectM = 5;
            evaluationDataA.FuncTech1 = 5;
            evaluationDataA.FuncTech2 = 4;
            evaluationDataA.FuncTech3 = 6;
            evaluationDataA.Front1 = 3;
            evaluationDataA.Front2 = 4;
            evaluationDataA.Back1 = 4;
            evaluationDataA.Back2 = 5;
            evaluationDataA.Archit = 3;
            evaluationDataA.Qa1 = 3;
            evaluationDataA.Qa2 = 5;
            evaluationDataA.Qa3 = 6;
            evaluationDataA.EvaluatorId = 5;
            evaluationDataA.EvaluateeId = 5;
            evaluationDataA.EvaluationId = 3;

            var evaluationDataB = new EvaluationData();
            evaluationDataB.Id = 2;
            evaluationDataB.ProjectM = 4;
            evaluationDataB.FuncTech1 =4;
            evaluationDataB.FuncTech2 = 3;
            evaluationDataB.FuncTech3 = 6;
            evaluationDataB.Front1 = 5;
            evaluationDataB.Front2 = 6;
            evaluationDataB.Back1 = 3;
            evaluationDataB.Back2 = 4;
            evaluationDataB.Archit = 3;
            evaluationDataB.Qa1 = 5;
            evaluationDataB.Qa2 = 6;
            evaluationDataB.Qa3 = 4;
            evaluationDataB.EvaluatorId = 6;
            evaluationDataB.EvaluateeId = 5;
            evaluationDataB.EvaluationId = 4;

            var evaluationDataC = new EvaluationData();
            evaluationDataC.Id = 0;
            evaluationDataC.ProjectM = 1;
            evaluationDataC.FuncTech1 = 4;
            evaluationDataC.FuncTech2 = 3;
            evaluationDataC.FuncTech3 = 5;
            evaluationDataC.Front1 = 5;
            evaluationDataC.Front2 = 6;
            evaluationDataC.Back1 = 5;
            evaluationDataC.Back2 = 0;
            evaluationDataC.Archit = 4;
            evaluationDataC.Qa1 = 5;
            evaluationDataC.Qa2 = 6;
            evaluationDataC.Qa3 = 4;
            evaluationDataC.EvaluatorId = 6;
            evaluationDataC.EvaluateeId = 5;
            evaluationDataC.EvaluationId = 5;


            //Act
            var isValidA = EvaluationDataService.ValidateEvaluetionData(evaluationDataA);
            var isValidB = EvaluationDataService.ValidateEvaluetionData(evaluationDataB);
            var isValidC = EvaluationDataService.ValidateInsertEvaluationData(evaluationDataC);


            //Assert

            Assert.AreEqual(true, isValidA, "El testede modelo de evaluetionDataA ha fallado.");
            Assert.AreEqual(true, isValidB, "Ocurrio un error message");
            Assert.AreEqual(false, isValidC, "Custom error message");

        }
    }
}

﻿using coderview_API.Service;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class BootcampItemTest
    {
        [TestMethod]
        public void ValidateBootcampItemTest()
        {
            //Arrange
            var bootcampA = new BootcampItem();
            bootcampA.Id = 3;
            bootcampA.CreatorId = 4;
            bootcampA.StartDate = DateTime.Now.AddDays(-1);
            bootcampA.EndDate = DateTime.Now.AddDays(-1);


            var bootcampB = new BootcampItem();
            bootcampB.Id = 5;
            bootcampB.CreatorId = 6;
            bootcampB.StartDate = DateTime.Now.AddDays(-1);
            bootcampB.EndDate = DateTime.Now.AddDays(-1);

            var bootcampC = new BootcampItem();
            bootcampC.Id = 8;
            bootcampC.CreatorId = -1;
            bootcampC.StartDate = DateTime.Now.AddDays(10);
            bootcampC.EndDate = DateTime.Now.AddDays(-100);


            //Act
            var isValidA = BootcampService.ValidateBootcamp(bootcampA);
            var isValidB = BootcampService.ValidateBootcamp(bootcampB);
            var isValidC = BootcampService.ValidateBootcamp(bootcampC);
          

            //Assert        

            Assert.AreEqual(false, isValidA, "¡Vaya! El bootcamp no ha sido registrado correctamente");
            Assert.AreEqual(false, isValidB, "¡Estas campo no acepta string");
            Assert.AreEqual(false, isValidC, "¡Estas campo esta vacio");



        }
    }
}
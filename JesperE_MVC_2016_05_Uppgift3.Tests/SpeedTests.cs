using System;
using JesperE_MVC_2016_05_Uppgift3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JesperE_MVC_2016_05_Uppgift3.Tests
{
    [TestClass]
    public class SpeedTests
    {
        [TestMethod]
        public void GetCurrentSpeedTest1()
        {

            Assert.IsTrue(Calculations.GetCurrentSpeed(3,4)==3/4);
        }

        [TestMethod]
        public void GetCurrentSpeedTest2()
        {
            Assert.IsFalse(Calculations.GetCurrentSpeed(4,4)==55);

        }
        [TestMethod]
        public void GetCurrentSpeedTest3()
        {
            Assert.IsNotNull(Calculations.GetCurrentSpeed(55,33));
        }
    }
}

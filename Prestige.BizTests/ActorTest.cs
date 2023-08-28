using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;
using System;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            // Act
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestParameterizedConstructor()
        {
            // Arrange
            var currenrActor = new Actor("Johny Boy");
            var expected = "Johny Boy";
            // Act
            string result = currenrActor.ActorName;
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

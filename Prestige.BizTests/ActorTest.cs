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
        [TestMethod]
        public void TestBookActor() { 
            // Arrange
            string details = " Booking can change if" +
                " actor starts trouble.";
            var currenrActor = new Actor("Johny Boy");
            var expected = "Actor Johny Boy is booked. "
                + details;
            // Act
            string result = currenrActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            // Arrange
            string details = "Booking can change if" +
                " actor starts trouble.";
            var currenrActor = new Actor("Johny Boy");
            var expected = "Actor Johny Boy is booked on " +
                DateTime.Today.ToShortDateString() + ". " + details;
            // Act
            string result = currenrActor.BookActor
                            (DateTime.Today.ToShortDateString());
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

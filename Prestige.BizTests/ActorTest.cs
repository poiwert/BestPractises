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
        public void TestSettingObjectProperty()
        {
            // Arrange
            var currenrActor = new Actor();
            currenrActor.ActorName = "Johny Boy";
            var expected = "Johny Boy";
            // Act
            string result = currenrActor.ActorName;
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestBookActor() { 
            // Arrange
            string details = "Booking can change if" +
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
        [TestMethod]
        public void TestFormattingOnSetterForBookActor()
        {
            // Arrange
            string details = "Booking can change if" +
                " actor starts trouble.";
            var currenrActor = new Actor("Johny Boy   ");
            var expected = "Actor Johny Boy is booked. "
                + details;
            // Act
            string result = currenrActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Sandy Love"};
            var expected = "Regular actor";
            // Act
            string result = currentActor.ActorDescription;
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            // Arrange
            var currentActor = new Actor { ActorName = "Sandy Love",
                                           ActorAge = 46};
            var expected = 46;
            // Act
            int result = currentActor.ActorAge;
            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGetAgency()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Prestige Talent";
            // Act
            string result = currentActor.GetAgency();
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

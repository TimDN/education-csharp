using Dummy.Bookings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dummy.UnitTest.Bookings
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanCancel_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation(new User());
            var user = new User { IsAdmin = true };

            //Act
            var actual = reservation.CanCancel(user);

            //Asssert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CanCancel_ReservedUserCancelling_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation(user);

            //Act
            var actual = reservation.CanCancel(user);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CanCancel_OtherUserCancelling_ReturnsFalse()
        {
            //Arrange
            var otherUser = new User();
            var reservation = new Reservation(new User());

            //Act
            var actual = reservation.CanCancel(otherUser);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        //Assert
        [ExpectedException(typeof(ArgumentNullException))]
        public void CanCancel_UserIsNull_ThrowsArgumentNull()
        {
            //Arrange
            var reservation = new Reservation(new User());

            //Act
            reservation.CanCancel(null);
        }


        [TestMethod]
        //Assert
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReservedBy_UserIsNull_ThrowsArgumentNull()
        {
            //Arrange
            var reservation = new Reservation(new User());

            //Act
            reservation.ReservedBy = null;
        }
    }
}

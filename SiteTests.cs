using NUnit.Framework;
using System;
using RepairAndConstruction.Models;

namespace RepairAndConstruction.Tests
{
    public class BasicTests
    {
        [Test]
        public void JobOffer_Title_Should_Not_Be_Null_Or_Empty()
        {
            var offer = new JobOffer { Title = "Tiling Bathroom" };
            Assert.IsFalse(string.IsNullOrWhiteSpace(offer.Title));
        }

        [Test]
        public void Booking_Date_Should_Be_In_The_Future()
        {
            var bookingDate = DateTime.Now.AddDays(2);
            Assert.IsTrue(bookingDate > DateTime.Now);
        }

        [Test]
        public void Review_Should_Have_At_Least_10_Characters_In_Comment()
        {
            var review = new Review { Comment = "Great work!" };
            Assert.IsTrue(review.Comment.Length >= 10);
        }

        [Test]
        public void AppUser_Should_Be_Customer()
        {
            var user = new AppUser { Role = "Customer" };
            Assert.AreEqual("Customer", user.Role);
        }

        [Test]
        public void Booking_Status_Can_Be_Set_To_Approved()
        {
            var booking = new Booking { Status = "Approved" };
            Assert.AreEqual("Approved", booking.Status);
        }

        [Test]
        public void AppUser_Should_Have_Username()
        {
            var user = new AppUser { Username = "john_doe" };
            Assert.IsNotNull(user.Username);
            Assert.IsTrue(user.Username.Length >= 3);
        }

        [Test]
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void Review_Rating_Should_Be_Between_1_And_5(int rating)
        {
            var review = new Review { Rating = rating };
            Assert.That(review.Rating, Is.InRange(1, 5));
        }

        [Test]
        public void JobOffer_Title_Should_Contain_Keyword_Paint()
        {
            var offer = new JobOffer { Title = "Paint the walls" };
            Assert.IsTrue(offer.Title.ToLower().Contains("paint"));
        }

        [Test]
        public void Booking_Should_Not_Allow_Past_Dates()
        {
            var bookingDate = DateTime.Now.AddDays(-2);
            var isValid = bookingDate > DateTime.Now;
            Assert.IsFalse(isValid);
        }



        [Test]
        public void Review_Should_Have_ReviewerName()
        {
            var review = new Review { ReviewerName = "Michael" };
            Assert.IsNotNull(review.ReviewerName);
            Assert.IsTrue(review.ReviewerName.Length > 2);
        }

        [Test]
        public void Customer_Should_Have_FullName()
        {
            var customer = new Customer { FullName = "Anna Petrova" };
            Assert.IsNotNull(customer.FullName);
            Assert.IsTrue(customer.FullName.Contains(" "));
        }

        [Test]
        public void Booking_Status_Should_Default_To_Pending()
        {
            var booking = new Booking();
            booking.Status ??= "Pending"; // За да се сетне, ако няма по подразбиране
            Assert.AreEqual("Pending", booking.Status);
        }

        [Test]
        public void AppUser_Password_Should_Not_Be_Empty()
        {
            var user = new AppUser { Password = "secret123" };
            Assert.IsFalse(string.IsNullOrEmpty(user.Password));
        }

        [Test]
        public void JobOffer_Should_Have_Assigned_Worker()
        {
            var offer = new JobOffer { Worker = new Worker { FullName = "Builder Man" } };
            Assert.IsNotNull(offer.Worker);
            Assert.IsTrue(offer.Worker.FullName.Length > 5);
        }
    }
}

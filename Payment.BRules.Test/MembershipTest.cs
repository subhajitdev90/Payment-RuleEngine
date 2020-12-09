using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Rules;

namespace Payment.BRules.Test
{
    [TestClass]
    public class MembershipTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var membership = new Membership();
            var result = membership.Handle("new");

            // Assert
            Assert.AreEqual("Activate Membership", result);
        }

        [TestMethod]
        public void CheckNullRules()
        {
            var membershipMock = new Mock<Membership> { CallBase = true };
            var result = membershipMock.Setup(m => m.Handle("new")).Returns("Activate Membership");
            // Assert
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new Membership();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Activate Membership", result);

        }
    }
}

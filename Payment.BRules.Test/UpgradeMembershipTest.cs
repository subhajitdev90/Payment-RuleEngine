using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.BRules.Test
{
    [TestClass]
    public class UpgradeMembershipTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var upmembership = new UpgradeMembership();
            var result = upmembership.Handle("upgrade");

            // Assert
            Assert.AreEqual("Apply the upgrade\n", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var upmembershipMock = new Mock<UpgradeMembership> { CallBase = true };
            var result = upmembershipMock.Setup(m => m.Handle("upgrade")).Returns("Apply the upgrade\n");
            // Assert
            Assert.IsNotNull(result);    

        }

        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new UpgradeMembership();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Apply the upgrade\n", result);

        }
    }
}

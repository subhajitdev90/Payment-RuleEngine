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
    public class CommissionPaymentTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var comptm = new CommissionPayment();
            var result = comptm.Handle("commission");

            // Assert
            Assert.AreEqual("Generate a commission payment to the agent", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var comptmMock = new Mock<CommissionPayment> { CallBase = true };
            var result = comptmMock.Setup(m => m.Handle("commission")).Returns("Generate a commission payment to the agent");
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new CommissionPayment();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Generate a commission payment to the agent", result);

        }
    }
}

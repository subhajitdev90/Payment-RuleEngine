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
    public class SendEmailTest
    {
        [TestMethod]
        public void ValidateRules()
        {

            var emailMock = new SendEmail();
            var email = emailMock.Handle("email");

            // Assert
            Assert.AreEqual("Send Email about subscription", email);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var emailMock = new Mock<SendEmail> { CallBase = true };
            var email = emailMock.Setup(m => m.Handle("email")).Returns("Send Email about subscription");

            // Assert
            Assert.IsNotNull(email);

        }

        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new SendEmail();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Send Email about subscription", result);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine.Rules;

namespace Payment.BRules.Test
{
    [TestClass]
    public class PhysicalProductTest
    {
     
        [TestMethod]
        public void ValidateRules()
        {
            var phyproduct = new PhysicalProduct();
            var result = phyproduct.Handle("physical");

            // Assert
            Assert.AreEqual("Create a packing slip for shipping", result); 

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var phyproductMock = new Mock<PhysicalProduct> { CallBase = true };
            var result = phyproductMock.Setup(m => m.Handle("physical")).Returns("Create a packing slip for shipping");
            // Assert
            Assert.IsNotNull(result);   

        }


        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new PhysicalProduct();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Create a packing slip for shipping", result);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RulesEngine;
using RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.BRules.Test
{
    [TestClass]
    public class AbstractHandlerTest
    {
        public Mock<Video> videoMock;
        public AbstractHandlerTest()
        {
            videoMock = new Mock<Video> { CallBase = true };
            videoMock.Setup(m => m.Handle("video")).Returns("Add a 'First Aid' video to the packing sleep");

        }

        [TestMethod]
        public void ValidateRules()
        {
            var _abstractHandler = new Mock<AbstractHandler>();
            var result = _abstractHandler.Setup(m => m.Handle(videoMock.Object)).Returns(null);
            // Assert
            Assert.IsNotNull(result);

        }
    }
}

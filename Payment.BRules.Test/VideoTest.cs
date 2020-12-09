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
    public class VideoTest
    {
        [TestMethod]
        public void ValidateRules()
        {
            var video = new Video();
            var result = video.Handle("video");

            // Assert
            Assert.AreEqual("Add a 'First Aid' video to the packing sleep", result);

        }

        [TestMethod]
        public void CheckNullRules()
        {
            var videoMock = new Mock<Video> { CallBase = true };
            var result = videoMock.Setup(m => m.Handle("video")).Returns("Add a 'First Aid' video to the packing sleep");
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void RuleNotMatch()
        {
            var phyproduct = new Video();
            var result = phyproduct.Handle("Failure");

            // Assert
            Assert.AreNotEqual("Add a 'First Aid' video to the packing sleep", result);

        }
    }
}

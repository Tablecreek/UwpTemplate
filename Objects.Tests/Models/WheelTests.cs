using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

using Objects.Models;

namespace Objects.Tests.Models {
    [TestClass]
    public class WheelTests {
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext) {

        }

        [TestInitialize]
        public void InitializeMethod() {

        }

        [TestMethod]
        public void CalculateCompleteTireHeight() {
            var wheel = new Wheel();
            var tire = new Tire();
            var rim = new Rim();

            tire.HeightToWidthRatio = 50;
            tire.WidthInMillimeters = 225;
            rim.DiameterInInches = 15;
            wheel.Tire = tire;
            wheel.Rim = rim;

            Assert.AreEqual(606, wheel.HeightInMillimeters);
        }

        [TestCleanup]
        public void CleanUpMethod() {

        }

        [ClassCleanup]
        public static void CleanUpClass() {

        }
    }
}

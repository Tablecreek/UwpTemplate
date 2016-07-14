using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

using Objects.Models;

namespace Objects.Tests.Models {

    [TestClass]
    public class TireTests {

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext) {

        }

        [TestInitialize]
        public void InitializeMethod() {

        }

        [TestMethod]
        public void CalculateSidewallHeight() {
            var tire = new Tire();

            tire.WidthInMillimeters = 225;
            tire.HeightToWidthRatio = 50;

            Assert.AreEqual(112.5, tire.SideWallHeight);
        }

        [TestCleanup]
        public void CleanUpMethod() {

        }

        [ClassCleanup]
        public static void CleanUpClass() {

        }

    }

}

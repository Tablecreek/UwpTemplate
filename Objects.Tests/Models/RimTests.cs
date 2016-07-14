using System.Threading.Tasks;

using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

using Objects.Models;

namespace Objects.Tests.Models {

    [TestClass]
    public class RimTests {

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext) {
            
        }

        [TestInitialize]
        public void InitializeMethod() {

        }

        [TestMethod]
        public void ConvertDiameterInInchesToMilliMeter() {
            var rim = new Rim();

            rim.DiameterInInches = 15;

            Assert.AreEqual(381, rim.DiameterInMillimeters);
        }

        [TestCleanup]
        public void CleanUpMethod() {

        }

        [ClassCleanup]
        public static void CleanUpClass() {

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        Computer test_computer;
        Laptop test_laptop;
        SmartPhone test_smartphone;

        [TestInitialize]
        public void CreateTestObjects()
        {
            test_computer = new Computer(256, "Windows", 12);
            test_laptop = new Laptop(true, 512, "IOS", 48);
            test_smartphone = new SmartPhone(1080, 764, "Chrome", 72);
        }

        //COMPUTER TEST
        [TestMethod]
        public void TestComputerOutput()
        {
            Assert.AreEqual("Thats a nice one!", test_computer.YourComputer());
        }

        [TestMethod]
        public void TestSsdValueInComputer()
        {
            Assert.AreEqual(256, test_computer.Ssd, 0.001);
        }

        [TestMethod]
        public void TestOperatingSytemValueInComputer()
        {
            Assert.AreEqual("Windows", test_computer.OperatingSystem);
        }

        [TestMethod]
        public void TestRamValueInComputer()
        {
            Assert.AreEqual(12, test_computer.Ram, 0.001);
        }

        //LAPTOP TEST
        [TestMethod]
        public void TestLaptopOutput()
        {
            Assert.AreEqual("That is a cool one", test_laptop.ThatsCool());
        }

        [TestMethod]
        public void TestTouchScreenValueInLaptop()
        {
            Assert.AreEqual(true, test_laptop.TouchScreen);
        }

        [TestMethod]
        public void TestSsdValueInLaptop()
        {
            Assert.AreEqual(512, test_laptop.Ssd, 0.001);
        }

        [TestMethod]
        public void TestOperatingSytemValueInLaptop()
        {
            Assert.AreEqual("IOS", test_laptop.OperatingSystem);
        }

        [TestMethod]
        public void TestRamValueInLaptop()
        {
            Assert.AreEqual(48, test_laptop.Ram, 0.001);
        }

        //SMARTPHONE TEST
        [TestMethod]
        public void TestSmartPhoneOutput()
        {
            Assert.AreEqual("Wow! That phone has great resolution", test_smartphone.PhoneSpec());
        }

        [TestMethod]
        public void TestTouchScreenValueInSmartPhone()
        {
            Assert.AreEqual(1080, test_smartphone.ScreenRes, 0.001);
        }

        [TestMethod]
        public void TestSsdValueInSmartPhone()
        {
            Assert.AreEqual(764, test_smartphone.Ssd, 0.001);
        }

        [TestMethod]
        public void TestOperatingSytemValueInSmartPhone()
        {
            Assert.AreEqual("Chrome", test_smartphone.OperatingSystem);
        }

        [TestMethod]
        public void TestRamValueInSmartPhone()
        {
            Assert.AreEqual(72, test_smartphone.Ram, 0.001);
        }
        
    }
}

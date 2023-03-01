namespace Calculation
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            int a = 1, b= 2;

            int result = Operations.Add(a, b);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMinus()
        {
            int a = 2, b = 1;

            int result = Operations.Minus(a, b);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMultiply()
        {
            int a = 5, b = 2;

            int result = Operations.Multiply(a, b);

            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestDivide()
        {
            int a = 4, b = 2;

            int result = Operations.Divide(a, b);

            Assert.AreEqual(2, result);
        }
    }
}
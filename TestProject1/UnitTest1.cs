using FunctionProject;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add()
        {
            int a = 10;
            int b = 20;
            int excpected = 30;
            MyCalc c =new MyCalc();
            int actual = MyCalc.Add(a, b);
            Assert.AreEqual(excpected, actual);
        }
        [Test]
        public void Subtract()
        {
            int a = 30;
            int b = 20;
            int excpected = 10;
            MyCalc c = new MyCalc();
            int actual = MyCalc.Subtract(a, b);
            Assert.AreEqual(excpected, actual);
        }
        [Test]
        public void Multiply()
        {
            int a = 2;
            int b = 5;
            int excpected = 10;
            MyCalc c = new MyCalc();
            int actual = MyCalc.Multiply(a, b);
            Assert.AreEqual(excpected, actual);
        }
    }
}
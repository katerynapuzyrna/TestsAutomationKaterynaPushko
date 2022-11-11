using TestsAutomationKaterynaPushko;

namespace UnitTests.Tests
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("Positive scenarios")]
        [Test]
        public void Test1()
        {
            int firstNumber = 1000;
            int secondNumber = -1000;
            int expectedResult = firstNumber * secondNumber;

            int actualResult = MathOperations.Multiply(firstNumber, secondNumber);

            Assert.True(actualResult == expectedResult, $"Actual multiplication result of {firstNumber} and {secondNumber} is {actualResult}. Expected result is {expectedResult}");
        }

        [Category("Positive scenarios")]
        [Test]
        public void Test2()
        {
            int firstNumber = -1000;
            int secondNumber = 1000;
            int expectedResult = firstNumber * secondNumber;

            int actualResult = MathOperations.Multiply(firstNumber, secondNumber);

            Assert.True(actualResult == expectedResult, $"Actual multiplication result of {firstNumber} and {secondNumber} is {actualResult}. Expected result is {expectedResult}");
        }

        [Category("Positive scenarios")]
        [Test]
        public void Test3()
        {
            int firstNumber = 5;
            int secondNumber = 17;
            int expectedResult = firstNumber * secondNumber;

            int actualResult = MathOperations.Multiply(firstNumber, secondNumber);

            Assert.True(actualResult == expectedResult, $"Actual multiplication result of {firstNumber} and {secondNumber} is {actualResult}. Expected result is {expectedResult}");
        }

        [Category("Negative scenarios")]
        [Test]
        public void Test4()
        {
            int firstNumber = 1001;
            int secondNumber = -1000;

            Assert.Throws<Exception>(() => MathOperations.Multiply(firstNumber, secondNumber), $"There is no Exception while trying to multiply {firstNumber} and {secondNumber}. Expected result is to have Exception because one or both parameters are out of range [1000; -1000]");
        }

        [Category("Negative scenarios")]
        [Test]
        public void Test5()
        {
            int firstNumber = -100;
            int secondNumber = 1001;

            Assert.Throws<Exception>(() => MathOperations.Multiply(firstNumber, secondNumber), $"There is no Exception while trying to multiply {firstNumber} and {secondNumber}. Expected result is to have Exception because one or both parameters are out of range [1000; -1000]");
        }

        [Category("Negative scenarios")]
        [Test]
        public void Test6()
        {
            int firstNumber = -1001;
            int secondNumber = 1001;

            Assert.Throws<Exception>(() => MathOperations.Multiply(firstNumber, secondNumber), $"There is no Exception while trying to multiply {firstNumber} and {secondNumber}. Expected result is to have Exception because one or both parameters are out of range [1000; -1000]");
        }
    }
}
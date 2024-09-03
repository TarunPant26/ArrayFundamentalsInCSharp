using ConsoleApp13;
using NUnit.Framework;

namespace Test_Array_Fundamentals
{
    public class Tests
    {
        [TestCase(new int[] { 10, 1, 11, 2, 4, 5, 6, 7, }, 10)]
        [TestCase(new int[] { 12, 11, 11, 2, 4, 5, 6, 7, }, 11)]
        [TestCase(new int[] { 10, 10, 10, 10 }, -1)]
        public void SecondLargest__WhenCalled_ShouldReturnSecondLargestNumber(int[] input, int output)
        {

            var result = SecondLargest.FindSecondLargest(input);

            Assert.AreEqual(output, result);
        }
    }
}
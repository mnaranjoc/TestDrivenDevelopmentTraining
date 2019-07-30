using NUnit.Framework;

namespace Chapter1
{
    [TestFixture]
    public class UtilitiesTests
    {
        [TestCase]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;
            var classUnderTest = new StringUtilities();
            var actualResult =
            classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase]
        public void SearchShouldBeCaseSenstive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult =
            classUnderTest.CountOccurences(stringToCheck,
            stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using PatternLogic;

namespace PatternUnitTests
{
    [TestFixture]
    public class IntegerPatternTests
    {
        private IIntegerPatterns _integerPatterns;


        [SetUp]
        public void Setup()
        {
            _integerPatterns = new IntegerPatterns();
        }


        [Test]
        public void ParseInput_ValidInputString_ReturnsListOfIntegers()
        {
            string input = "6 1 5 9 2";
            List<int> expected = new List<int> { 6, 1, 5, 9, 2 };
            List<int> result = Utilities.ParseInput(input);

            Assert.AreEqual(expected, result);
        }


        [Test]
        public async Task FindLongestIncreasingSubsequence_ValidInput_ReturnsLongestIncreasingSubsequence()
        {
            List<int> input = new List<int> { 6, 1, 5, 9, 2 };
            List<int> expected = new List<int> { 1, 5, 9 };
            List<int> result = await _integerPatterns.FindLongestIncreasingSubsequence(input);

            Assert.AreEqual(expected, result);
        }


    }
}
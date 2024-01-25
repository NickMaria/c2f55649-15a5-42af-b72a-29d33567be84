namespace PatternLogic
{
    public interface IIntegerPatterns
    {
        Task<List<int>> FindLongestIncreasingSubsequence(List<int> numbers);
    }
}

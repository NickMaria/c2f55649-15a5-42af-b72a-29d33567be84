namespace PatternLogic
{
    public interface IIntegerPatterns
    {
        Task<string> FindLongestIncreasingSubsequence(string numbersList);

        Task<List<int>> FindLongestIncreasingSubsequence(List<int> numbers);
    }
}

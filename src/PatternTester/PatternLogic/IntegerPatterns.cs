namespace PatternLogic
{
    public class IntegerPatterns : IIntegerPatterns
    {
        public async Task<List<int>> FindLongestIncreasingSubsequence(List<int> numbers)
        {
            var result = new List<int>();

            try
            {
                // Longest Increasing Subsequence - lis
                int[] lis = new int[numbers.Count];
                int[] previous = new int[numbers.Count];

                for (int i = 0; i < numbers.Count; i++)
                {
                    lis[i] = 1;
                    previous[i] = -1;

                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] > numbers[j] && lis[i] < lis[j] + 1)
                        {
                            lis[i] = lis[j] + 1;
                            previous[i] = j;
                        }
                    }
                }

                int maxLengthIndex = Array.IndexOf(lis, lis.Max());

                while (maxLengthIndex != -1)
                {
                    result.Insert(0, numbers[maxLengthIndex]);
                    maxLengthIndex = previous[maxLengthIndex];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return result;
        }

    }
}

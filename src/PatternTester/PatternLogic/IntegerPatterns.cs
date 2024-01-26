using System.Text;

namespace PatternLogic
{
    public class IntegerPatterns : IIntegerPatterns
    {
        public async Task<string> FindLongestIncreasingSubsequence(string numbersList)
        {
            var numbers = new List<int>();

            try
            {
                // Convert the input string to a list of integers
                var parsedNumbers = numbersList.Split(' ').Select(int.Parse);
                numbers = parsedNumbers.ToList();
            }
            catch (Exception argEx)
            {
                Console.WriteLine(argEx);
                throw new ArgumentException("Input is invalid");
            }

            List<int> numberListResult;

            try
            {
                numberListResult = await FindLongestIncreasingSubsequence(numbers);
            }
            catch (Exception procEx)
            {
                Console.WriteLine(procEx);
                throw;
            }

            // alter for display output
            var sb = new StringBuilder();
            foreach (int number in numberListResult)
            {
                sb.Append(number);
                sb.Append(" ");
            }

            string result = sb.ToString().Trim();

            return result;
        }

        public async Task<List<int>> FindLongestIncreasingSubsequence(List<int> numbers)
        {
            List<int> longestSequence = new List<int>();

            try
            {
                if (numbers == null || numbers.Count == 0)
                {
                    return new List<int>();
                }

                List<int> currentSequence = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0 || numbers[i] > numbers[i - 1])
                    {
                        currentSequence.Add(numbers[i]);
                    }
                    else
                    {
                        if (currentSequence.Count > longestSequence.Count)
                        {
                            longestSequence = new List<int>(currentSequence);
                        }
                        currentSequence.Clear();
                        currentSequence.Add(numbers[i]);
                    }
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return longestSequence;
        }

    }
}

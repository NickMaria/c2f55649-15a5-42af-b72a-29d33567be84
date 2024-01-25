namespace PatternLogic
{
    public class Utilities
    {

        public static List<int> ParseInput(string input)
        {
            return input.Split(' ').Select(int.Parse).ToList();
        }


    }
}

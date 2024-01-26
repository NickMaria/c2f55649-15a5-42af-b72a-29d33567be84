using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PatternLogic;

namespace PatternTester.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IIntegerPatterns _integerPatterns;

        public IndexModel(ILogger<IndexModel> logger, IIntegerPatterns integerPatterns)
        {
            _logger = logger;
            _integerPatterns = integerPatterns;
        }

        [BindProperty]
        public string InputIntegerList { get; set; }

        public string OutputIntegerList { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            // Handle the form submission when the user clicks the "Submit" button.

            try
            {
                OutputIntegerList = await _integerPatterns.FindLongestIncreasingSubsequence(InputIntegerList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                OutputIntegerList = "Your Input Integer List is invalid";
            }

            return Page();
        }

        public IActionResult OnPostClear()
        {
            // Handle the "Clear" button action by resetting the 'InputIntegerList' & 'OutputIntegerList' property.
            InputIntegerList = string.Empty;

            return Page();
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TempDataTests.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [TempData]
        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            Message = "something added";

            // ��ת�� IndexPeek �� IndexKeep ������ɾ�� `TempData["Message"]
            //return RedirectToPage("./IndexPeek");
            //return RedirectToPage("./IndexKeep");

            // ��ת�� IndexNoKeepOrPeek���ڻ�ȡֵ�󣬻�ɾ�� `TempData["Message"]            
            return RedirectToPage("./IndexNoKeepOrPeek");
        }
    }
}

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

            // 跳转至 IndexPeek 和 IndexKeep 将不会删除 `TempData["Message"]
            //return RedirectToPage("./IndexPeek");
            //return RedirectToPage("./IndexKeep");

            // 跳转至 IndexNoKeepOrPeek，在获取值后，会删除 `TempData["Message"]            
            return RedirectToPage("./IndexNoKeepOrPeek");
        }
    }
}

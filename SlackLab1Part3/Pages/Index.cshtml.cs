using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SlackLab1Part3.Pages.DB;

namespace SlackLab1Part3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
   
        public void OnPostInsertDummyData()
        {
            DBClass.InsertDummyData();
        }
    }

}


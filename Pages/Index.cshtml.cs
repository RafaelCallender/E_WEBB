using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_WEBB.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPostBookNow()
        {
            return RedirectToPage("/Contact_Use");
        }
        public IActionResult OnPostAboutus()
        {
            return RedirectToPage("/aboutus");
        }
    }

}


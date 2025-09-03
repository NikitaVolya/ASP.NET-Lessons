using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class InfoModel : PageModel
    {

        public void OnGet()
        {
            ViewData["message"] = "Hello, world!";
        }
    }
}

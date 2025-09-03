using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class HelloModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Hello, student";
        }
    }
}

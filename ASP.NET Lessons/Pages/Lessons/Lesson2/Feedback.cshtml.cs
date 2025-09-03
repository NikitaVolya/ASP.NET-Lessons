using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class FeedbackModel : PageModel
    {
        [BindProperty]
        public string Feedback { get; set; }

        public void OnGet()
        {
            ViewData["feedback"] = "No feedback yet";
        }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(Feedback))
            {
                ViewData["feedback"] = Feedback;
            }
        }
    }
}

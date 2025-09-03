using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = $"Hello, {Name}";
        }
    }
}

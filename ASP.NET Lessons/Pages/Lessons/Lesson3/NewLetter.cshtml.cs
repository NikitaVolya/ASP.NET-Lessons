using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson3
{
    public class NewLetterModel : PageModel
    {
        [BindProperty]
        [Required, EmailAddress]
        public string Email { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TempData["Message"] = "Thank you for subscribing!";
            return RedirectToPage("Success");
        }
    }
}

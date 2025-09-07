using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson3
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [Required, StringLength(50)]
        public string Name { get; set; }

        [BindProperty]
        [Required, EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required, StringLength(1000, MinimumLength =6)]
        public string Password { get; set; }

        [BindProperty]
        [Required, Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("Success");
            }
            return Page();
        }
    }
}

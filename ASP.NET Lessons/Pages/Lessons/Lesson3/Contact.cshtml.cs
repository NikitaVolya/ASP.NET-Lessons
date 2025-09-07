using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson3
{
    public class MessageData
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }

    public class ContactModel : PageModel
    {
        public MessageData[] Messages { get; set; } = new MessageData[0];


        [BindProperty]
        [Required, StringLength(100)]
        public string FullName { get; set; }

        [BindProperty]
        [Required, EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Required, StringLength(1000, MinimumLength =10)]
        public string Message { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Messages.Append(new MessageData { FullName=FullName, Email=Email, Message=Message });
                return RedirectToPage("ThankYou");
            }
            return Page();
        }
    }
}

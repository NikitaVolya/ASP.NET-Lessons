using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASP_NET_Lessons.Models;


namespace ASP.NET_Lessons.Pages.Lessons.Lesson4.Exercice2
{
    public class IndexModel : PageModel
    {

        public  User[] Users => new User[] {
            new User{ Name = "Jennie", Email = "jennie.nichols@example.com", AvatarUrl = "https://randomuser.me/api/portraits/thumb/men/75.jpg", Id = 0},
            new User{ Name = "Jack", Email = "jack.nichols@example.com", AvatarUrl = "https://randomuser.me/api/portraits/women/36.jpg", Id = 1},
        };

        public void OnGet()
        {
        }
    }
}

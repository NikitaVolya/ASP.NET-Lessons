using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class ProductModel : PageModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int PageNumber { get; set; }

        // Використовую назву pageNumber бо pag вже за резервоване
        public void OnGet(string color, int pageNumber, int id)
        {
            Color = color ?? "Null";
            PageNumber = pageNumber;
            Id = id;
        }
    }
}

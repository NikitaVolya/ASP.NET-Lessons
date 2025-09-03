using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Lessons.Pages.Lessons.Lesson2
{
    public class SearchModel : PageModel
    {
        public string Query { get; set; }
        public int Num { get; set; }

        public void OnGet(string query, int num)
        {
            Query = query;
            Num = num;
        }
    }
}

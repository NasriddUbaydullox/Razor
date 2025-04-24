using loyaut_razorpages.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loyaut_razorpages.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;
        public IndexModel(Context context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Meals> MealList { get; set; } = new List<Meals>();

        public void OnGet()
        {
            MealList= _context.Meals.ToList();
        }
    }
}

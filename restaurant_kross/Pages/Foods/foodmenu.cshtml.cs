using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace restaurant_kross.Pages.Foods;

public class foodmenuModel : PageModel
{
    public List<string> Meals = new() { "salad", "shorva" , "steyk"};
    public void OnGet()
    {
    }
}

public class Meal 
{
    public string Name { get; set; }
    public bool isVegen { get; set; }
}


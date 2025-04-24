using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace restaurant_kross.Pages.Foods;

public class steakModel : PageModel
{
    public void OnGet()
    {
    }
}


public class Steak 
{
    public string Name { get; set; }    
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shkurt.Data;
using Shkurt.Entities;
using Shkurt.ViewModels;

namespace Shkurt.Pages;

public class IndexModel(ShkurtDbContext shkurtDbContext) : PageModel
{

    [BindProperty]
    public ShortUrlCreateViewModel ShortUrl { get; set; } = default!;

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
            return Page();
        ShortUrl shortUrl = new()
        {
            OriginalUrl = ShortUrl.OriginalUrl
        };
        shkurtDbContext.ShortUrls.Add(shortUrl);
        await shkurtDbContext.SaveChangesAsync();
        var request = HttpContext.Request;
        TempData["ShortUrl"] = $"{request.Scheme}://{request.Host}/{shortUrl.Id}";
        return Redirect("/Result");
    }
}

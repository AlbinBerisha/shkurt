using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shkurt.Data;
using Shkurt.Entities;
using Shkurt.Helpers;
using Shkurt.ViewModels;

namespace Shkurt.Pages;

public class IndexModel(ShkurtDbContext shkurtDbContext) : PageModel
{
    [BindProperty]
    public ShortUrlCreateViewModel ShortUrl { get; set; } = default!;
    public string GeneratedShortUrl { get; set; } = null!;

    public async Task OnPost()
    {
        if (!ModelState.IsValid)
            return;
        var id = ShortIdGenerator.Generate();
        ShortUrl shortUrl = new()
        {
            Id = id,
            OriginalUrl = ShortUrl.OriginalUrl
        };
        shkurtDbContext.ShortUrls.Add(shortUrl);
        await shkurtDbContext.SaveChangesAsync();
        var request = HttpContext.Request;
        GeneratedShortUrl = $"{request.Scheme}://{request.Host}/{shortUrl.Id}";
    }
}

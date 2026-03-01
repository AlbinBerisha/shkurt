using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shkurt.Data;
using Shkurt.Entities;

namespace Shkurt.Pages.ShortUrls;

public class IndexModel(ShkurtDbContext context) : PageModel
{
	public IList<ShortUrl> ShortUrl { get; set; } = default!;

	public async Task OnGetAsync()
	{
		ShortUrl = await context.ShortUrls.ToListAsync();
	}
}

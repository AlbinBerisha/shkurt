using Microsoft.AspNetCore.Mvc;
using Shkurt.Data;
using Shkurt.Entities;

namespace Shkurt.Controllers;

[Route("")]
public class ShortUrlController(ShkurtDbContext dbContext) : Controller
{
	[HttpGet("{id}")]
	public async Task<IActionResult> RedirectTo(Guid id)
	{
		ShortUrl? shortUrl = await dbContext.ShortUrls.FindAsync(id);
		if (shortUrl == null)
		{
			return NotFound();
		}
		return Redirect(shortUrl.OriginalUrl);
	}
}

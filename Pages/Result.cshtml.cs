using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shkurt.Pages;

public class ResultModel : PageModel
{
	[TempData]
	public string? ShortUrl { get; set; }
}

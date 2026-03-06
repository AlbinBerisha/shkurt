using System.ComponentModel.DataAnnotations;

namespace Shkurt.ViewModels;

public class ShortUrlCreateViewModel
{
	[Url]
	[Required]
	[Required(ErrorMessage = "The URL is required")]
	public required string OriginalUrl { get; set; }
}

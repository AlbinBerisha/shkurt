using System.ComponentModel.DataAnnotations;

namespace Shkurt.ViewModels;

public class ShortUrlCreateViewModel
{
	[Required(ErrorMessage = "The URL is required")]
	public required string OriginalUrl { get; set; }
}

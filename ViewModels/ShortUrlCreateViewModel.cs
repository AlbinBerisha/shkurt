using System.ComponentModel.DataAnnotations;

namespace Shkurt.ViewModels;

public class ShortUrlCreateViewModel
{
	[Url]
	[Required]
	public required string OriginalUrl { get; set; }
}

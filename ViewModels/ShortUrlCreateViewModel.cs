using System.ComponentModel.DataAnnotations;

namespace Shkurt.ViewModels;

public class ShortUrlCreateViewModel
{
	[Required]
	public required string OriginalUrl { get; set; }
}

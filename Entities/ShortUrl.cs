namespace Shkurt.Entities;

public class ShortUrl
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public required string OriginalUrl { get; set; }
}

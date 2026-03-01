using Microsoft.EntityFrameworkCore;
using Shkurt.Entities;

namespace Shkurt.Data;

public class ShkurtDbContext(DbContextOptions<ShkurtDbContext> options) : DbContext(options)
{
    public DbSet<ShortUrl> ShortUrls { get; set; } = default!;
}

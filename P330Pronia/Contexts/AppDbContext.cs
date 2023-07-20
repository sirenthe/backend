using Microsoft.EntityFrameworkCore;
using P330Pronia.Models;

namespace P330Pronia.Contexts
{
	public class AppDbContext :DbContext

	{
		public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
		{
		}

		public DbSet<Slider>? Sliders { get; set; } = null;
		public DbSet<cards>? cards { get; set; } = null;
	}
}

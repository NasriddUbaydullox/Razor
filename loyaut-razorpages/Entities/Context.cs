using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace loyaut_razorpages.Entities;

public class Context : DbContext
{
	public DbSet<Meals> Meals { get; set; }

	public Context(DbContextOptions<Context> options) : base(options)
	{

	}
}

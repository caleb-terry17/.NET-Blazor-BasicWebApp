using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
	public class PizzaContext : DbContext
	{
		public DbSet<Pizza> Pizzas { get; set; }

		public PizzaContext(DbContextOptions options) : base(options)
		{

		}
	}
}

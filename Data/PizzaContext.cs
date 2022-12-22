using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
	public class PizzaContext : DbContext
	{
		public DbSet<Pizza> Pizzas { get; set; }

		public PizzaContext() : base() {}
		public PizzaContext(DbContextOptions options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=pizza.db");
		}
	}
}

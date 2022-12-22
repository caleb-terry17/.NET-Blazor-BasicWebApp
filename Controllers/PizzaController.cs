using BlazorApp.Data;
using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Controllers
{
	[Route("pizzas")]
	[ApiController]
	public class PizzaController : Controller
	{
		private readonly PizzaContext _db;

		public PizzaController(PizzaContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<ActionResult<List<Pizza>>> GetPizza()
		{
			return (await _db.Pizzas.ToListAsync()).OrderByDescending(p => p.Price).ToList();
		}

		[HttpPost]
		public IActionResult Create(Pizza pizza)
		{
			// This code will save the pizza and return a result
			_db.Pizzas.Add(pizza);
			_db.SaveChanges();
			return CreatedAtAction(nameof(Create), new { Name = pizza.Name }, pizza);
		}
	}
}

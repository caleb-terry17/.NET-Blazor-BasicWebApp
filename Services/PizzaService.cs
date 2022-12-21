using BlazorApp.Models;

namespace BlazorApp.Services
{
    public class PizzaService
    {
        //public Task<List<Pizza>> GetPizzasAsync()
        public List<Pizza> GetPizzas()
        {
            return pizzas;
        }

        private readonly List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
            new Pizza { Id = 2, Name = "Buffalo chicken", Price =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl="img/pizzas/meaty.jpg"},
            new Pizza { Id = 3, Name = "Veggie Delight", Price =  11.5M, Description = "It's like salad, but on a pizza", ImageUrl="img/pizzas/salad.jpg"},
            new Pizza { Id = 4, Name = "Margherita", Price =  9.99M, Description = "Traditional Italian pizza with tomatoes and basil", ImageUrl="img/pizzas/margherita.jpg"},
            new Pizza { Id = 5, Name = "Basic Cheese Pizza", Price =  11.99M, Description = "It's cheesy and delicious. Why wouldn't you want one?", ImageUrl="img/pizzas/cheese.jpg"},
            new Pizza { Id = 6, Name = "Classic pepperoni", Price =  10.5M, Description = "It's the pizza you grew up with, but Blazing hot!", ImageUrl="img/pizzas/pepperoni.jpg" }
        };
    }
}

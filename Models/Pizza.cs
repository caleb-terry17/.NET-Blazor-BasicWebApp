namespace BlazorApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public string ImageUrl { get; set; }
        public int Size { get; set; }

        public static int DefaultSize { get; } = 10;
        public static int MinimumSize { get; } = 4;
        public static int MaximumSize { get; } = 20;
    }
}

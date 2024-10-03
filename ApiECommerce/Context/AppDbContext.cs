using ApiECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiECommerce.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail>  OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Snacks", UrlImage = "lanches1.png" },
                new Category { Id = 2, Name = "Combos", UrlImage = "combos1.png" },
                new Category { Id = 3, Name = "Naturals", UrlImage = "naturais1.png" },
                new Category { Id = 4, Name = "Drinks", UrlImage = "refrigerantes1.png" },
                new Category { Id = 5, Name = "Juices", UrlImage = "sucos1.png" },
                new Category { Id = 6, Name = "Desserts", UrlImage = "sobremesas1.png" }
            );

            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Name = "Standard Hamburger", UrlImage = "hamburger1.jpeg", CategoryId = 1, Price = 15, Stock = 13, Available = true, BestSeller = true, Popular = true, Details = "Soft bun, seasoned beef patty, onions, mustard, and ketchup" },
               new Product { Id = 2, Name = "Standard Cheeseburger", UrlImage = "hamburger3.jpeg", CategoryId = 1, Price = 18, Stock = 10, Available = true, BestSeller = false, Popular = true, Details = "Soft bun, seasoned beef patty, and cheese all around." },
               new Product { Id = 3, Name = "Standard CheeseSalad", UrlImage = "hamburger4.jpeg", CategoryId = 1, Price = 19, Stock = 13, Available = true, BestSeller = false, Popular = false, Details = "Soft bun, seasoned beef patty, onions, lettuce, mustard, and ketchup" },
               new Product { Id = 4, Name = "Hamburger, French fries, soda", UrlImage = "combo1.jpeg", CategoryId = 2, Price = 25, Stock = 10, Available = false, BestSeller = false, Popular = true, Details = "Soft bun, seasoned beef patty and cheese, soda, and fries" },
               new Product { Id = 5, Name = "Cheeseburger, French fries, soda", UrlImage = "combo2.jpeg", CategoryId = 2, Price = 27, Stock = 13, Available = true, BestSeller = false, Popular = false, Details = "Soft bun, seasoned beef patty, soda, and fries, onions, mayonnaise, and ketchup" },
               new Product { Id = 6, Name = "CheeseSalad, French fries, soda", UrlImage = "combo3.jpeg", CategoryId = 2, Price = 28, Stock = 10, Available = true, BestSeller = false, Popular = true, Details = "Soft bun, seasoned beef patty, soda, and fries, onions, mayonnaise, and ketchup" },
               new Product { Id = 7, Name = "Natural Sandwich with lettuce", UrlImage = "lanche_natural1.jpeg", CategoryId = 3, Price = 14, Stock = 13, Available = true, BestSeller = false, Popular = false, Details = "Whole wheat bread with lettuce and tomatoes" },
               new Product { Id = 8, Name = "Natural Sandwich with cheese", UrlImage = "lanche_natural2.jpeg", CategoryId = 3, Price = 15, Stock = 10, Available = true, BestSeller = false, Popular = true, Details = "Whole wheat bread, lettuce, tomatoes, and cheese." },
               new Product { Id = 9, Name = "Vegan Sandwich", UrlImage = "lanche_vegano1.jpeg", CategoryId = 3, Price = 25, Stock = 18, Available = true, BestSeller = false, Popular = false, Details = "Vegan sandwich with healthy ingredients" },
               new Product { Id = 10, Name = "Coca-Cola", UrlImage = "coca_cola1.jpeg", CategoryId = 4, Price = 21, Stock = 7, Available = true, BestSeller = false, Popular = true, Details = "Coca-Cola soda" },
               new Product { Id = 11, Name = "Guarana", UrlImage = "guarana1.jpeg", CategoryId = 4, Price = 25, Stock = 6, Available = true, BestSeller = false, Popular = false, Details = "Guarana soda" },
               new Product { Id = 12, Name = "Pepsi", UrlImage = "pepsi1.jpeg", CategoryId = 4, Price = 21, Stock = 6, Available = true, BestSeller = false, Popular = false, Details = "Pepsi Cola soda" },
               new Product { Id = 13, Name = "Orange Juice", UrlImage = "suco_laranja.jpeg", CategoryId = 5, Price = 11, Stock = 10, Available = true, BestSeller = false, Popular = false, Details = "Delicious and nutritious orange juice" },
               new Product { Id = 14, Name = "Strawberry Juice", UrlImage = "suco_morango1.jpeg", CategoryId = 5, Price = 15, Stock = 13, Available = true, BestSeller = false, Popular = false, Details = "Fresh strawberry juice" },
               new Product { Id = 15, Name = "Grape Juice", UrlImage = "suco_uva1.jpeg", CategoryId = 5, Price = 13, Stock = 10, Available = true, BestSeller = false, Popular = false, Details = "Natural grape juice with no sugar, made from the fruit" },
               new Product { Id = 16, Name = "Water", UrlImage = "agua_mineral1.jpeg", CategoryId = 4, Price = 5, Stock = 10, Available = true, BestSeller = false, Popular = false, Details = "Fresh mineral water" },
               new Product { Id = 17, Name = "Chocolate Cookies", UrlImage = "cookie1.jpeg", CategoryId = 6, Price = 8, Stock = 10, Available = true, BestSeller = false, Popular = true, Details = "Chocolate cookies with chocolate chunks" },
               new Product { Id = 18, Name = "Vanilla Cookies", UrlImage = "cookie2.jpeg", CategoryId = 6, Price = 8, Stock = 13, Available = true, BestSeller = true, Popular = false, Details = "Delicious and crunchy vanilla cookies" },
               new Product { Id = 19, Name = "Swiss Cake", UrlImage = "torta_suica1.jpeg", CategoryId = 6, Price = 10, Stock = 10, Available = true, BestSeller = false, Popular = true, Details = "Swiss cake with cream and layers of dulce de leche" }
            );
        }
    }
}

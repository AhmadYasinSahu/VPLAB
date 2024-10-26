using System;
using System.Collections.Generic;
using System.Timers;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(int id, string name, decimal price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

public class ShoppingCart
{
    private List<Product> Products { get; set; }
    private DateTime ExpirationTime { get; set; }
    private const int EXPIRATION_MINUTES = 10; // 10 minutes

    public ShoppingCart()
    {
        Products = new List<Product>();
        ExpirationTime = DateTime.Now.AddMinutes(EXPIRATION_MINUTES);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine($"\n\t\tAdded Product: {product.Name}\n");
    }

    public void RemoveProduct(int id)
    {
        var productToRemove = Products.Find(p =>p.Id == id);
        if (productToRemove != null)
        {
            Products.Remove(productToRemove);
            Console.WriteLine($"\n\t\tRemoved Product ID: {id}\n");
        }
        else
        {
            Console.WriteLine("\n\t\tProduct has not found.\n");
        }
    }

    public void ViewCart()
    {
        Console.WriteLine("Your Cart:\n");
        foreach (var product in Products)
        {
            Console.WriteLine($"\n\t\tName: {product.Name}      ||       Quantity: {product.Quantity}        || Price:       ${product.Price * product.Quantity}\n");
        }
    }

    public void UpdateQuantity(int id, int newQuantity)
    {
        var productToUpdate = Products.Find(p => p.Id == id);
        if (productToUpdate != null)
        {
            productToUpdate.Quantity = newQuantity;
            Console.WriteLine($"\t\t\tUpdated Quantity for Product ID: {id}\n");
        }
        else
        {
            Console.WriteLine("\n\t\tProduct not found.\n");
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price * product.Quantity;
        }
        return total;
    }

    public void ApplyDiscount(decimal discountPercentage)
    {
        decimal total = CalculateTotal();
        decimal discount = total * discountPercentage / 100;
        Console.WriteLine($"\n\t\tDiscount: ${discount}\n");
        Console.WriteLine($"\n\t\tTotal after discount: ${total - discount}\n");
    }

    public void Checkout()
    {
        Console.WriteLine("\n\n\t\tCheckout Summary:\n");
        ViewCart();
        Console.WriteLine($"\n\t\tTotal: ${CalculateTotal()}\n");
        Console.WriteLine("\n\t\tThanks you for shopping!\n");
        Products.Clear();
        ExpirationTime = DateTime.Now.AddMinutes(EXPIRATION_MINUTES);
    }

    public void CheckExpiration(Object source,ElapsedEventArgs e)
    {
        if (DateTime.Now > ExpirationTime)
        {
            Console.WriteLine("\n\t\t\t\tCart has expired. Please restart shopping.\n");
            Products.Clear();
        }
    }

    public void RecommendProducts()
    {
        Console.WriteLine("\n\n\t\t\tRecommended Products:\n");
        var recommendedProducts = new List<Product>
        {
            new Product(101, "Wireless Headphones", 29.99m, 1),
            new Product(102, "Smartphone Stand", 15.99m, 1),
            new Product(103, "Portable Charger", 24.99m, 1),
            new Product(104, "Bluetooth Speaker", 49.99m, 1),
            new Product(105, "Fitness Tracker", 39.99m, 1)
        };

        foreach (var product in Products)
        {
             GetRecommendedProducts(product.Price);
            foreach (var recommendedProduct in recommendedProducts)
            {
                Console.WriteLine($"\n\t\tName:   {recommendedProduct.Name}    ||      Price:  ${recommendedProduct.Price}\n");
            }
        }
    }

    private List<Product> GetRecommendedProducts(decimal price)
    {
        var recommendedProducts = new List<Product>
        {
            new Product(1, "\n\t\tRecommended Product 1", price - 10, 1),
            new Product(2, "\n\t\tRecommended Product 2", price + 10, 1)
        };
        return recommendedProducts;
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        System.Timers.Timer timer = new System.Timers.Timer(60000);
        timer.Elapsed += cart.CheckExpiration;
        timer.Start();

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\t\t\t\t===============================================");
            Console.WriteLine("\t\t\t\t||            Shopping Cart System           ||");
            Console.WriteLine("\t\t\t\t===============================================");
            Console.WriteLine("\t\t\t\t||                                           ||");
            Console.WriteLine("\t\t\t\t||    1. Add Product to Cart                 ||");
            Console.WriteLine("\t\t\t\t||    2. Remove Product from Cart            ||");
            Console.WriteLine("\t\t\t\t||    3. Update Product Quantity             ||");
            Console.WriteLine("\t\t\t\t||    4. View Cart                           ||");
            Console.WriteLine("\t\t\t\t||    5. Calculate Total                     ||");
            Console.WriteLine("\t\t\t\t||    6. Apply Discount                      ||");
            Console.WriteLine("\t\t\t\t||    7. Checkout                            ||");
            Console.WriteLine("\t\t\t\t||    8. Get Product Recommendations         ||");
            Console.WriteLine("\t\t\t\t||    9. Exit                                ||");
            Console.WriteLine("\t\t\t\t||                                           ||");
            Console.WriteLine("\t\t\t\t===============================================");
            Console.ResetColor();
            Console.Write("\n\t\t\t\tEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||    1. Add Product to Cart                 ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.Write("\n\t\tEnter product ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n\t\tEnter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("\n\t\tEnter product price: ");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n\t\tEnter product quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product(id, name, price, quantity);
                    cart.AddProduct(product);
                    Console.WriteLine("\t\t\t\t\t\t\t Products have been added.");
                    Console.WriteLine("\t\t\t\t\t=================================================");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t===============================================");
                    Console.WriteLine("\t\t\t||    2. Remove Product from Cart            ||");
                    Console.WriteLine("\t\t\t===============================================");
                    Console.Write("\n\t\tEnter product ID to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    cart.RemoveProduct(removeId);
                    Console.WriteLine("\t\t\t\t Product has been removed.");
                    Console.WriteLine("\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||    3. Update Product Quantity             ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.Write("\n\t\tEnter product ID to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n\t\tEnter new quantity: ");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    cart.UpdateQuantity(updateId, newQuantity);
                    Console.WriteLine("\n\t\t\t\t Product quantity has been  updated.");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||           4. View Cart                      ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    cart.ViewCart();
                    Console.WriteLine("\n\n\t\t\t\t\t\t Thanks to use our service.");
                    Console.WriteLine("\t\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||      5. Calculate Total                   ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.WriteLine($"\n\t\tTotal: ${cart.CalculateTotal()}\n");
                    Console.WriteLine("\n\n\t\t\t\t Your total bill has been calsulated.");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||    6. Apply Discount                      ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.Write("\n\t\tEnter discount percentage: ");
                    decimal discountPercentage = Convert.ToDecimal(Console.ReadLine());
                    cart.ApplyDiscount(discountPercentage);
                    Console.WriteLine($"\n\n\t\t\t\t"+discountPercentage+" Discount has been applied .");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||    7. Checkout                            ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    cart.Checkout();
                    Console.WriteLine("\n\n\t\t\t\t Cart has een checked out.");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n\t\t\t===============================================");
                    Console.WriteLine("\t\t\t||    8. Get Product Recommendations         ||");
                    Console.WriteLine("\t\t\t===============================================");
                    cart.RecommendProducts();
                    Console.WriteLine("\n\n\t\t\t\t Products have been recommended.");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();

                    break;
                case 9:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t===============================================");
                    Console.WriteLine("\t\t\t\t||    9. Exit                                ||");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Environment.Exit(0);
                    Console.WriteLine("\n\n\t\t\t\t Thanks to use our service .");
                    Console.WriteLine("\t\t\t\t===============================================");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("\n\t\tInvalid choice. Please try again.\n");
                    break;
            }

        }
    }
}

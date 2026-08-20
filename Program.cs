List<Product> products = new List<Product>();

Product product = new Product();
product.Name = "Headphones";
product.Price = 60000;
products.Add(product);

Product product2 = new Product();
product2.Name = "Mouse";
product2.Price = 50000;
products.Add(product2);

Product product3 = new Product();
product3.Name = "Keyboard";
product3.Price = 80000;
products.Add(product3);

while (true)
{
    // Menu

    Console.WriteLine("=== MINI TIENDA ===");
Console.WriteLine("1. Ver productos");
Console.WriteLine("2. Agregar producto al carrito");
Console.WriteLine("3. Ver carrito");
Console.WriteLine("4. Finalizar compra");
Console.WriteLine("5. Salir");

Console.Write("Ingrese una opción: ");
string option = Console.ReadLine();

if (option == "5")
{
    break;
}

if (option == "1")
 { 
    Console.WriteLine("=== PRODUCTOS ===");

    int number = 1;

    foreach (Product item in products)
    {
        Console.WriteLine(number + ". " + item.Name + " - $" + item.Price.ToString("N0"));
        
        number++;
    }
 }
 else
 {
    Console.WriteLine("Opción no disponible todavía.");
 }
}

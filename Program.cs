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

List<Product> cart = new List<Product>();

while (true)
{
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
    else if (option == "2")
    {
        Console.WriteLine("=== PRODUCTOS ===");

        int number = 1;

        foreach (Product item in products)
        {
            Console.WriteLine(number + ". " + item.Name + " - $" + item.Price.ToString("N0"));
            number++;
        }

        Console.Write("Seleccione el número del producto: ");
        int selected = int.Parse(Console.ReadLine());

        if (selected >= 1 && selected <= products.Count)
        {
            Product selectedProduct = products[selected - 1];

            cart.Add(selectedProduct);

            Console.WriteLine(selectedProduct.Name + " agregado al carrito.");
        }
        else
        {
            Console.WriteLine("Producto no válido.");
        }
    }
    else if (option == "3")
    {
        Console.WriteLine("=== CARRITO ===");

        decimal total = 0;

        foreach (Product item in cart)
        {
            Console.WriteLine(item.Name + " - $" + item.Price.ToString("N0"));
            total += item.Price;
        }

        Console.WriteLine("Total: $" + total.ToString("N0"));
    }
    else if (option == "4")
    {
        decimal total = 0;

        foreach (Product item in cart)
        {
            total += item.Price;
        }

        Console.WriteLine("Total de la compra: $" + total.ToString("N0"));
        Console.Write("¿Confirmar compra? (S/N): ");
        string confirm = Console.ReadLine();

        if (confirm.ToUpper() == "S")
        {
            Console.WriteLine("Compra realizada correctamente.");
            cart.Clear();
        }
        else
        {
            Console.WriteLine("Compra cancelada.");
        }
    }
    else
    {
        Console.WriteLine("Opción no disponible.");
    }
}
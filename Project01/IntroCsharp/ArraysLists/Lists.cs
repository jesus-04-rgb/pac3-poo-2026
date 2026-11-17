namespace Project01.IntroCsharp.ArraysLists
{
    public class Lists
    {
      public void Products()
        {
            List<string> products = new List<string>();

            products.Add("Laptop");
            products.Add("Semitas");
            products.Add("Coca-Cola");
            products.Insert(0, "Azúcar");
            products.Insert(2, "Chocolate");
            //products.Remove("Galletas");
            //products.RemoveAt(0);
            
            products.Sort();
            products.Reverse();
            //products.Clear();
            
           foreach (var product in products)
            {
                Console.WriteLine($"Producto: {product}");
            } 
            
            Console.WriteLine($"Ingrese la cantidad total de productos que desea agregar: {products.Count} ");
        } 
    public void MenuCompras()
        {
            List<string> products = new List<string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Lista de compras");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Ver lista");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");

                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del producto a agregar: ");
                        string? productToAdd = Console.ReadLine()?.Trim();

                        if (string.IsNullOrWhiteSpace(productToAdd))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        products.Add(productToAdd);
                        Console.WriteLine($"Producto '{productToAdd}' agregado a la lista.");
                        break;

                    case "2":
                        if (products.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                            break;
                        }

                        Console.WriteLine("Lista de productos:");
                        foreach (var product in products)
                        {
                            Console.WriteLine($"{product}");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre del producto a eliminar: ");
                        string? productToRemove = Console.ReadLine()?.Trim();

                        if (string.IsNullOrWhiteSpace(productToRemove))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        int index = products.FindIndex(p =>
                            p.Equals(productToRemove, StringComparison.OrdinalIgnoreCase));

                        if (index >= 0)
                        {
                            products.RemoveAt(index);
                            Console.WriteLine($"Producto '{productToRemove}' eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"Producto '{productToRemove}' no encontrado en la lista.");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Hasta luego.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
        public void ListaCompras()
        {
            List<string> products = new List<string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Lista de compras");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Ver lista");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string? option = Console.ReadLine()?.Trim();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del producto a agregar: ");
                        string? productToAdd = Console.ReadLine()?.Trim();

                        if (string.IsNullOrWhiteSpace(productToAdd))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        products.Add(productToAdd);
                        Console.WriteLine($"Producto '{productToAdd}' agregado a la lista.");
                        break;

                    case "2":
                        if (products.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                            break;
                        }

                        Console.WriteLine("Lista de productos:");
                        foreach (var product in products)
                        {
                            Console.WriteLine($"{product}");
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre del producto a eliminar: ");
                        string? productToRemove = Console.ReadLine()?.Trim();

                        if (string.IsNullOrWhiteSpace(productToRemove))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        int index = products.FindIndex(p =>
                            p.Equals(productToRemove, StringComparison.OrdinalIgnoreCase));

                        if (index >= 0)
                        {
                            products.RemoveAt(index);
                            Console.WriteLine($"Producto '{productToRemove}' eliminado de la lista.");
                        }
                        else
                        {
                            Console.WriteLine($"Producto '{productToRemove}' no encontrado en la lista.");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Hasta luego.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
/*
Lista de compras 
1. Agregar
2. Ver lista
3. Eliminar
4. Salir
*/
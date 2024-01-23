using ProductTagsExample.Entities;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, Used or Imported product? (c/u/i) ");
    string productType = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (productType == "c")
    {
        products.Add(new Product(name, price));
    }
    else if (productType == "u")
    {
        Console.Write("Manufacture date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, date));
    }
    else if (productType == "i")
    {
        Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine());

        products.Add(new ImportedProduct(name, price, customsFee));
    }
}

Console.WriteLine();
Console.WriteLine("ITEMS:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
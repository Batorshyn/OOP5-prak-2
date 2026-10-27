using System.Text.Json;
using OOP5_prak_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string jsonString = """
{
    "Id": 2,
    "Name": "Ноутбук",
    "Price": 32000.00,
    "Quantity": 5
}
""";

Product? product = JsonSerializer.Deserialize<Product?>(jsonString);

if (product is not null)
{
    Console.WriteLine("Десеріалізований об'єкт успішно відновлено:");
    Console.WriteLine($"ID: {product.Id}");
    Console.WriteLine($"Назва: {product.Name}");
    Console.WriteLine($"Ціна: {product.Price} грн");
    Console.WriteLine($"Кількість: {product.Quantity} шт.");
}

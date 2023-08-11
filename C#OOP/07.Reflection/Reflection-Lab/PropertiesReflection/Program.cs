using System.Reflection;

PropertyInfo[] properties = typeof(Product).GetProperties((BindingFlags)60);

foreach (var property in properties)
{
    Console.WriteLine("Name: " + property.Name);
    Console.WriteLine("Property Type: " + property.PropertyType.Name);

    Console.WriteLine("Property Value: " + property.GetValue(new Product()));
    Console.WriteLine();
}

class Product
{
    public int Prop1 { get; set; }

    public string Prop2 { get; set; }
}
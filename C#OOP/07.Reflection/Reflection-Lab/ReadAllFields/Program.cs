
using System.Reflection;

Product product = new Product();

PrintAllFields(product);
PrintAllFields(DateTime.Now);


void PrintAllFields(object obj)
{
    Type type = obj.GetType();
    FieldInfo[] fields = type.GetFields();

    foreach (FieldInfo field in fields)
    {
        Console.WriteLine($"Name: {field.Name}");
        Console.WriteLine($"DeclaringType: {field.DeclaringType}");
        Console.WriteLine($"IsFamily: {field.IsFamily}");
        Console.WriteLine($"IsPublic: {field.IsPublic}");
        Console.WriteLine($"IsStatic: {field.IsStatic}");
        Console.WriteLine($"{field.Name} - {field.GetValue(obj)}");
        Type fieldType = field.FieldType;
        Console.WriteLine($"FieldType: {fieldType}");
        Console.WriteLine();
    }
}

public class Product
{
    public static int id;
    public decimal price;
    public string Model;
}
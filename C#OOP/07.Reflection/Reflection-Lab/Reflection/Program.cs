using Reflection;
using System.Reflection;

Type type = typeof(Laptop);

PropertyInfo[] properties = type.GetProperties();

foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
}
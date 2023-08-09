using ReflectedNamespace;
using Reflection;
using TypeClass3;

//Mouse mouse = new Mouse();
//Laptop laptop = new Laptop();

//PrintTypeInfo(mouse);
//PrintTypeInfo(laptop);

PrintTypeInfo(new Mouse());
PrintTypeInfo(new Laptop());

void PrintTypeInfo(Product product)
{
    Type type = product.GetType();
    Console.WriteLine($"{type.FullName}");
    Console.WriteLine($"{type.Name}");
    Console.WriteLine($"{type.Assembly}");
    Console.WriteLine($"IsArray: {type.IsArray}");
    Console.WriteLine($"IsAbstract: {type.IsAbstract}");
    Console.WriteLine($"IsClass: {type.IsClass}");
    Console.WriteLine($"IsPublic: {type.IsPublic}");
}

namespace ReflectedNamespace
{
    public class Reflected
    {

    }
}

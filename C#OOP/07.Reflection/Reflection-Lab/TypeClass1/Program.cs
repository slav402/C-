using ReflectedNamespace;

Reflected reflected = new Reflected();

PrintTypeInfo(reflected);

void PrintTypeInfo(Object obj)
{
    Type type = obj.GetType();
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

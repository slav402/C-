using ConstructorReflection2;
using System.Reflection;

Type type = typeof(Product);

ConstructorInfo[] constructors = type.GetConstructors();

foreach (ConstructorInfo constructor in constructors)
{
    ParameterInfo[] parameters = constructor.GetParameters();

    object[] paramValues = new object[parameters.Length];

    int index = 0;
    foreach (ParameterInfo paramInfo in parameters)
    {
        paramValues[index++] = GetDefault(paramInfo.ParameterType);
    }

    Product product = Activator.CreateInstance(type, paramValues) as Product;

    Console.WriteLine(product.Id);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Model);
}

object GetDefault(Type type)
{
    if (type.IsValueType)
    {
        return Activator.CreateInstance(type);
    }
    return null;
}


//Product product = Activator.CreateInstance(type, new object[] { 5,5m,"Hello"}) as Product;

//Console.WriteLine(product.Id);
//Console.WriteLine(product.Price);
//Console.WriteLine(product.Model);


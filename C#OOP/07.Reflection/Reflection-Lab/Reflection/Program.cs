using Reflection;
using System.Reflection;


PrintProperties(typeof(Laptop), new Laptop() { Id=1, Cores = 8, Price = 100, GPUModel = "Skup"});
PrintProperties(typeof(Mouse), new Mouse() { Id =2, Precision = 200, Price = 60, Model = "Uha"});
PrintProperties(typeof(DateTime), DateTime.Now);

void PrintProperties(Type type, Object obj)
{
    Console.WriteLine("\n------------------");
    Console.WriteLine(type.Name);
    Console.WriteLine("------------------");

    PropertyInfo[] properties = type.GetProperties();

    foreach (PropertyInfo property in properties)
    {
        Console.WriteLine($"{property.Name} - {property.GetValue(obj)}");
    }
}


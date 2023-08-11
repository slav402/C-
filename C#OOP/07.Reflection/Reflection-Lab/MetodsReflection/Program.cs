using System.Reflection;

Type type = typeof(Printer);
Printer printer = new Printer();
//MethodInfo[] methods = type.GetMethods((BindingFlags) 60);

MethodInfo method = type.GetMethod("Print");
MethodInfo method2 = type.GetMethod("DatePrint");

method.Invoke(printer, new object[] { 1, "test" });

DateTime date = (DateTime)method2.Invoke(printer, null);
Console.WriteLine(date);


MethodInfo[] methods = type.GetMethods();

//foreach (MethodInfo method in methods)
//{
//    Console.WriteLine(method.Name);
//    Console.WriteLine($"Return type: {method.ReturnType.Name}");
//    ParameterInfo[] parameters = method.GetParameters();

//    foreach (ParameterInfo param in parameters)
//    {
//        Console.WriteLine(param.Name);
//        Console.WriteLine(param.ParameterType.Name);
//    }
//    Console.WriteLine();
//}

class Printer
{
    public void Print(int param1, string param2)
    {
        Console.WriteLine("Public void print");
        Console.WriteLine($"param1: {param1}");
        Console.WriteLine($"param2: {param2}");
    }

    public void PrivatePrint()
    {
        Console.WriteLine("Private void print");
    }

    public DateTime DatePrint()
    {
        Console.WriteLine("Date print");
        return DateTime.Now;
    }
}
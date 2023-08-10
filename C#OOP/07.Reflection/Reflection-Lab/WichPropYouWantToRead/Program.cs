using System.Reflection;

while (true)
{
    Console.WriteLine("Wich property you want to read?");
    string propName = Console.ReadLine();

	try
	{
		GetPropertyValue(propName, DateTime.Now);
	}
	catch (Exception)
	{
        Console.WriteLine("No such property!");
    }

}

void GetPropertyValue(string propName, object obj)
{
	Type type = obj.GetType();

	PropertyInfo propInfo = type.GetProperty(propName);

    Console.WriteLine(propInfo.GetValue(obj));
}
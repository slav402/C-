using System.Reflection;
using TypeClass3;

Product product = new Product()
{
    field = 1,
    field2 = 2,
    field355 = 3,
    id = 4, 
    model = 17,
    price = 1
};

while (true)
{
    Console.WriteLine("Wich field you want to read?");

    string fieldName = Console.ReadLine();

    Type type = typeof(Product);

    FieldInfo field = type.GetField(fieldName);

    if (field == null) continue;

    Console.WriteLine(field.GetValue(product));

    field.SetValue(product, (int)field.GetValue(product) + 1);
}
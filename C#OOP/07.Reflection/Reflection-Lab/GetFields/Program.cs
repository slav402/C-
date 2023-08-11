using System.Reflection;

Type type = typeof(Product);


//----------------------------------- parwo re6enie
//FieldInfo[] fields = Type.GetFields(
//    BindingFlags.NonPublic 
//    | BindingFlags.Instance
//    | BindingFlags.Static
//    | BindingFlags.Public);
//-----------------------------------

//----------------------------------------------- wtoro re6enie
//BindingFlags allFields =
//    BindingFlags.NonPublic
//    | BindingFlags.Instance
//    | BindingFlags.Static
//    | BindingFlags.Public;

//Console.WriteLine((BindingFlags)60);
//Console.WriteLine((int)allFields);
//FieldInfo[] fields = type.GetFields(allFields);
//-----------------------------------------------

FieldInfo[] fields = type.GetFields((BindingFlags)60); // treto re6enie

foreach (FieldInfo field in fields)
{
    Console.WriteLine(field.Name);
}

public class Product 
{
    private int privateField;
    protected int protectedField;
    internal int internalField;
    public int publicField;

    public static int publicStaticField;
}


using System.ComponentModel.Design.Serialization;

Random random1 = (Random)Activator.CreateInstance(typeof(Random));

Random random2 = new Random();

Console.WriteLine(random1.Next());
Console.WriteLine(random2.Next());



DateTime date = (DateTime)InstanceCreator(typeof(DateTime));

object InstanceCreator(Type type)
{
    return Activator.CreateInstance(type);
}
using NUnit.Framework;
using System;
using System.Reflection;
using System.Linq;
using PlayersAndMonsters;

[TestFixture]
public class Tests_000_001
{
    private static Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateTypesExist()
    {
        var typesToAssert = new[]
        {
            "BladeKnight",
            "DarkKnight",
            "DarkWizard",
            "Elf",
            "Hero",
            "Knight",
            "MuseElf",
            "SoulMaster",
            "Wizard"
        };

        foreach (string typeName in typesToAssert)
        {
            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string nameOfClass, params string[] fieldss)
    {
        var classType = Type.GetType(nameOfClass);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
        var classInstance = Activator.CreateInstance(classType, new object[] { });
        var str = new StringBuilder();

        str.AppendLine($"Class under investigation: {nameOfClass}");
        foreach (var f in fields.Where(x => fieldss.Contains(x.Name)))
        {
            str.AppendLine($"{f.Name} = {f.GetValue(classInstance)}");
        }

        return str.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        var classType = Type.GetType(investigatedClass);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var methods2 = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        var str = new StringBuilder();
        foreach (var f in fields)
        {
            str.AppendLine($"{f.Name} must be private!");
        }
        foreach (var m in methods.Where(x => x.Name.StartsWith("get")))
        {
            str.AppendLine($"{m.Name} have to be public!");
        }
        foreach (var m in methods2.Where(x => x.Name.StartsWith("set")))
        {
            str.AppendLine($"{m.Name} have to be private!");
        }

        return str.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
        var str = new StringBuilder();
        str.AppendLine($"All Private Methods of Class: {className}");
        str.AppendLine($"Base Class: {classType.BaseType.Name}");
        foreach (var m in methods)
        {
            str.AppendLine(m.Name);
        }

        return str.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance|BindingFlags.Public);
        var str = new StringBuilder();

        foreach (var m in methods.Where(x => x.Name.StartsWith("get")))
        {
            str.AppendLine($"{m.Name} will return {m.ReturnType}");
        }
        foreach (var m in methods.Where(x=>x.Name.StartsWith("set")))
        {
            str.AppendLine($"{m.Name} will set field of {m.GetParameters().First().ParameterType}");
        }

        return str.ToString().Trim();
    }
}


using System;
using System.Reflection;

public static class CrossAssemblysGetType
{
    public static Type GetType(string typeName)
    {
        Assembly currentAssembly = Assembly.GetAssembly(typeof(NormalCalibration));     //Assembly Assembly.GetAssembly(Type type)：获取某个类所属的程序集
        return currentAssembly.GetType(typeName);                                       //Type Assembly.GetType(string name)：在这个程序集内按字符串查找
    }
}

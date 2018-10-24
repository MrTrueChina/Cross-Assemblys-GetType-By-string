using System;
using System.Reflection;

public static class CrossAssemblysGetType
{
    public static Type GetType(string typeName)
    {
        Assembly currentAssembly = Assembly.GetAssembly(typeof(NormalCalibration));     //Assembly Assembly.GetAssembly(Type type)：获取某个类所属的程序集
        /*
         *  这一步的参数是一个保证在普通文件夹的类，在这个演示里是 NormalCalibration，在实际应用时可以是随便一个普通文件夹的类，这种类在正常开发里绝对有的是
         */

        return currentAssembly.GetType(typeName);                                       //Type Assembly.GetType(string name)：在这个程序集内按字符串查找
    }
}

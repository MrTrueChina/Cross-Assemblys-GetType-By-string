using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

public class ExampleWindow : EditorWindow
{
    [MenuItem("Example/Example Window")]
    public static void GetWindow()
    {
        ExampleWindow window = (ExampleWindow)GetWindow(typeof(ExampleWindow));
        window.Show();
    }


    private void OnGUI()
    {
        if (GUILayout.Button("从Editor文件夹里用GetType获取普通文件夹里的脚本的类"))
        {
            Debug.Log(Type.GetType("GetTypeInNormalFolder"));
        }
        if (GUILayout.Button("从Editor文件夹里先获取程序集再通过GetType获取普通文件夹里的脚本的类"))
        {
            Assembly currentAssembly = Assembly.GetAssembly(typeof(NormalCalibration));
            Debug.Log(currentAssembly.GetType("NormalTarget"));
        }
    }
}

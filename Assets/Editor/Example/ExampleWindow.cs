using System;
using UnityEditor;
using UnityEngine;

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
        DrawGetTypeButton();
        DrawCrossAssemblyButton();
    }

    static void DrawGetTypeButton()
    {
        if (GUILayout.Button("从Editor文件夹里用GetType获取普通文件夹里的脚本的类"))
        {
            Debug.Log(Type.GetType("GetTypeInNormalFolder"));
        }
    }

    static void DrawCrossAssemblyButton()
    {
        if (GUILayout.Button("从Editor文件夹里先获取程序集再通过GetType获取普通文件夹里的脚本的类"))
        {
            Type type = CrossAssemblysGetType.GetType("NormalTarget");
            Debug.Log(type);
        }
    }
}

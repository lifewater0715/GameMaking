using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

public class Test : EditorWindow
{
    [MenuItem("window544/Test")]

    static void Init()
    {
        Test window = (Test)EditorWindow.GetWindow(typeof(Test));
        window.Show();
    }
    // Start is called before the first frame update
    void OnGUI()
    {
        Handles.color = Color.green;
        Handles.DrawRectangle(0, new Vector3(300, 300, 0), Quaternion.identity, 100);
        Handles.DrawSolidDisc(new Vector3(300, 300, 0),Vector3.forward, 100);
        Handles.DrawSolidDisc(new Vector3(10, 10, 0), Vector3.back, 100);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

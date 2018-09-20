using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DataTool))]

public class DataEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DataTool myScript = (DataTool)target;
        if(GUILayout.Button("Upload Data"))
        {
            myScript.UploadData();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabLoader : MonoBehaviour
{
    public static GameObject Init(string location)
    {
        var obj = Instantiate(Resources.Load(location, typeof(GameObject))) as GameObject;
        return obj;
    }

    public static GameObject Init(string location, GameObject parent = null)
    {
        var obj = Instantiate(Resources.Load(location, typeof(GameObject))) as GameObject;
        obj.transform.SetParent(parent.transform);
        obj.transform.position = Vector3.zero;
        return obj;
    }
}

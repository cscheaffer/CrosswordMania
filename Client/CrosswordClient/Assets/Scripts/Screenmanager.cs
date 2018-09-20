using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrosswordDLL;

public class Screenmanager : MonoBehaviour
{
    void Start()
    {
        PrefabLoader.Init("Screens/Background", gameObject);
        PrefabLoader.Init("Screens/" + ScreenNames.MenuScreen, gameObject);
    }

    public void Open(string screenname)
    {
        PrefabLoader.Init("Screens/" + screenname, FindScreenManager());
    }

    private GameObject FindScreenManager()
    {
        GameObject sm = GameObject.Find(ScreenNames.Screenmanager);
        return sm;
    }
    
}

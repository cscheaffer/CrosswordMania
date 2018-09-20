using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CrosswordDLL;

public class MenuScreen : MonoBehaviour {

    public void OnClick()
    {
        Screenmanager screenmanager = new Screenmanager();
        screenmanager.Open(ScreenNames.GameScreen);
        Destroy(gameObject);
    }
}

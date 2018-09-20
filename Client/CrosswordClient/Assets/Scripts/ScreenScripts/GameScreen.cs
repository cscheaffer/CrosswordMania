using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrosswordDLL;
public class GameScreen : MonoBehaviour
{
    public Crossword CrosswordAnchor;

    void Start()
    {
        CrosswordAnchor.CreateCrossword();
    }
    public void OnClick()
    {
        Screenmanager screenmanager = new Screenmanager();
        screenmanager.Open(ScreenNames.MenuScreen);
        Destroy(gameObject);
    }
}

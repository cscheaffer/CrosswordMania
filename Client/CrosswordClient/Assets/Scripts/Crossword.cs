using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrosswordDLL;
using UnityEngine.UI;

public class Crossword : MonoBehaviour
{
    //passsing in null for now
    //CrosswordCell [,] data
    public void CreateCrossword()
    {
        var sq = PrefabLoader.Init("Square", gameObject);
        sq.GetComponentInChildren<Text>().text = "A";
    }
}

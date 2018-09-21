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
        int length = 3;
        for(int i = 0; i < length; i++)
        {
            for(int j = 0; j < length; j++)
            {
                var sq = PrefabLoader.Init("Square", gameObject);
                sq.GetComponentInChildren<Text>().text = i.ToString();
                sq.transform.position = new Vector3(j - 1, i, 0);
            }
        }
    }
}

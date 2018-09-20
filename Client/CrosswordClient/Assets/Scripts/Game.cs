using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrosswordDLL;
public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var cc = new CrosswordCalculations();
        //Debug.Log(cc.Add(1, 2));
        Debug.Log(cc.GetWord("Dog"));
        Debug.Log(cc.GetClue("What is the opposite of dog?"));
        Debug.Log("end");
    }
    //providerName="System.Data.SqlClient"
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrosswordDLL;
using System;
using System.IO;

public class DataTool : MonoBehaviour
{
    public string Table;
    public string Filename;

    public void UploadData()
    {
        Debug.Log("Starting Upload");
        using (var reader = new StreamReader("Data/" + Filename + ".csv"))
        {
            List<Word> list = new List<Word>();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                Word temp = new Word(values[0], values[1], values[2]);
                list.Add(temp);
            }
            Helper.UploadData(list, Table);
        }
        Debug.Log("End Upload");
    }
}



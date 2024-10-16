using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighscoreData
{
    public float[] scores;
    public string[] names;

    //Constructor
    public HighscoreData() 
    {
        scores = new[] { 99f, 10f, 1f };
        names = new[] { "Andrew", "Alex", "Steve" };
    }

    public HighscoreData(float[] scores, string[] names)
    {
        this.scores = scores;
        this.names = names;
    }
}
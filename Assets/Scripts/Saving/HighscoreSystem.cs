using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HighscoreSystem : MonoBehaviour
{
    private List<string> names = new List<string>();
    private List<float> scores = new List<float>();

    public int maxScores = 10;

    private void Start()
    {
        RefreshScoreDisplay();
    }

    private void RefreshScoreDisplay()
    {
        for(int i = 0; i < scores.Count ;i++)
        {
            Debug.Log(names[i] + " scored: " + scores[i]);
        }
    }

    public void NewScore(string name, float score)
    {
        for(int index = 0; index < scores.Count ; index ++)
        {
            if(score < scores[index])
            {
                scores.Insert(index, score);
                names.Insert(index, name);
                RefreshScoreDisplay();
                if (scores.Count > maxScores)
                {
                    scores.RemoveAt(scores.Count - 1);
                    names.RemoveAt(names.Count - 1);
                }
                return;
            }
        }

        if (scores.Count < maxScores)
        {
            scores.Add(score);
            names.Add(name);
            RefreshScoreDisplay();
        }
    }
}

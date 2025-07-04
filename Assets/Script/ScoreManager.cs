using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private const string LABEL = "record";

    private void EditScore()
    {
        scoreText.text = "Score: " + Table.Instance.ciblesTouches;
    }

    public void Update()
    {
        if (!Table.Instance) return;
        
        EditScore();
        BestScore();
    }

    private void BestScore()
    {
        var scoreSave = PlayerPrefs.GetInt(LABEL, 0);

        if (scoreSave < Table.Instance.ciblesTouches)
        {
            scoreSave = Table.Instance.ciblesTouches;
        }
        
        PlayerPrefs.SetInt(LABEL, scoreSave);
    }
}

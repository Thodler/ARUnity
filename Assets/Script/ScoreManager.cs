using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public void EditScore()
    {
        scoreText.text = "Score:" + Table.Instance.ciblesTouches;
    }

    public void Update()
    {
        if (!Table.Instance)
        {
            return;
        }
        EditScore();
    }
}

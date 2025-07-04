using TMPro;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int recordScore;
    private const string LABEL = "record";

    void Start()
    {
        recordScore = PlayerPrefs.GetInt(LABEL, 0);
        Edit();
    }

    private void Edit()
    {
        scoreText.text = "Record: " + recordScore;
    }
}

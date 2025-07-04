using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Timer : MonoBehaviour
{
    private Timer instance;

    public TMP_Text timer;
    
    private float elapsedTime;
    
    public void Start()
    {
        instance = this;
        
        elapsedTime = 59f;
    }

    public void Update()
    {
        if(ObjectSpawner.Instance.enableSpawn) return;
        
        timer.gameObject.SetActive(true);
        elapsedTime -= Time.deltaTime;
        
        DisplayElapsedTime();
    }
    
    private void DisplayElapsedTime()
    {
        int seconds = (int) elapsedTime % 60;
        timer.text = seconds.ToString("D2");
        
        if (elapsedTime <= 0)
        {
            timer.gameObject.SetActive(false);
            ObjectSpawner.Instance.enableSpawn = true;
            
            PlayerPrefs.SetInt("Score", Table.Instance.ciblesTouches);
            
            
            Destroy(Table.Instance.gameObject);
            elapsedTime = 59f;
        }
    }
}

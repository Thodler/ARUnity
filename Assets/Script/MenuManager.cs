using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void OnStart()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExit()
    {
        Debug.Log("Une demande pour quitter le jeu a été reçue.");
        // Cette partie du code ne fonctionne que dans l'éditeur Unity.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;

        // Cette partie du code ne fonctionnera que dans un build de l'application.
        #else
            Application.Quit();
        #endif
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public static Table Instance;
    
    public List<GameObject> cibles = new List<GameObject>();
    private List<Vector3> positionsInitiales = new List<Vector3>();

    public int ciblesTouches = 0;
    
    private void Start()
    {
        Instance = this;
        
        foreach (GameObject cible in cibles)
        {
            positionsInitiales.Add(cible.transform.position);
        }

    }

    public void NouvelleCible()
    {
        ciblesTouches++;
        print(ciblesTouches);
        if (ciblesTouches % cibles.Count == 0)
        {
            print("Toutes les cibles sont tombé.");
            StartCoroutine(ResetWithDelay(2f));
        }
    }
    
    public void Reset()
    {
        print("Reset Component");
        
        foreach (GameObject cible in cibles)
        {
            if (cible.tag == "Balle")
            {
                cible.GetComponent<Rigidbody>().isKinematic = true;
                cible.GetComponent<MoveSphere>().enabled = true;
            }
            
            print(cible.transform.position);
            cible.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            cible.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            cible.transform.rotation = Quaternion.identity;
            cible.transform.position = positionsInitiales[cibles.IndexOf(cible)];
            cible.GetComponent<CibleIndividuelle>().down = false;
        }
    }
    
    private IEnumerator ResetWithDelay(float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        Reset();
    }

}

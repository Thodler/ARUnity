using System;
using UnityEngine;

public class CibleIndividuelle : MonoBehaviour
{
    public bool down;
    
    private void Update()
    {
        if (Vector3.Dot(transform.up, Vector3.up) > 0.9f) return;
        
        if (down) return;
        
        down = true;
        Table.Instance.NouvelleCible();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Balle" && other.gameObject.tag == "Balle")
        {
            if(down) return;
            
            down = true;
            Table.Instance.NouvelleCible();
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<MoveSphere>().enabled = false;

        }
    }
}

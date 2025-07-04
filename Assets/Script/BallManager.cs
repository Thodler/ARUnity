using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class BallManager : MonoBehaviour
{
    public GameObject ball;

    public void PlayerInput(InputAction.CallbackContext context)
    {
        if(ObjectSpawner.Instance.enableSpawn) return;
        
        if (context.performed)
        {
            print(context.interaction);
            GameObject nouveauProjectile = Instantiate(ball, transform.position, transform.rotation);
            nouveauProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 4, ForceMode.Impulse);
        }
    }
}

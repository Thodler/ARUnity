using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Spawner : MonoBehaviour
{
    public void Spawn()
    {
        ObjectSpawner.Instance.enableSpawn = false;
    }
}

using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float speed;
    private Vector3 randomPosition;
    
    void Start()
    {
        InvokeRepeating("PositionSphere", 0f, 5f);
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
    }
    
    void PositionSphere()
    {
        var maxInclusive = 0.5f;
        randomPosition = new Vector3(Random.Range(-maxInclusive, maxInclusive), transform.position.y, Random.Range(-maxInclusive, maxInclusive));
    }
}

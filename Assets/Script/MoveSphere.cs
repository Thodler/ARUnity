using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float speed;
    private Vector3 randomPosition;
    private Vector3 initalPosition;
    
    void Start()
    {
        InvokeRepeating("PositionSphere", 0f, 5f);
        initalPosition = transform.position;
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
    }
    
    void PositionSphere()
    {
        var maxInclusive = 0.5f;
        Vector3 newPosition = new Vector3(Table.Instance.transform.position.x, initalPosition.y, Table.Instance.transform.position.z);
        randomPosition = new Vector3(Random.Range(-maxInclusive, maxInclusive), 0, Random.Range(-maxInclusive, maxInclusive)) + newPosition;
    }
}

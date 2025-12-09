using UnityEngine;

public class MovingBucket : MonoBehaviour
{
    public GameObject movingBucket;
    void Update()
    {
        // Move the bucket back and forth between -10 and 11 on the x-axis
        movingBucket.transform.position = new Vector3(Mathf.PingPong(Time.time, 21) + -10, movingBucket.transform.position.y, movingBucket.transform.position.z);
    }
}

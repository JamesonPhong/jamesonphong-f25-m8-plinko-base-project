using UnityEngine;

public class Player : MonoBehaviour
{
    // Player movement speed, disc prefab, camera follow script, and player shoot sound effect script
    public float speed = 1;
    public GameObject disc;
    public CameraFollow cameraFollow;
    public PlayerShootSFX playSFX;
    private GameObject activeDisc;

    void Update()
    {
        // Handle player movement and disc dropping
        Move();
        DropDisc();
    }
    void DropDisc()
    {
        // Drop a disc when the fire button is pressed and no disc is currently active
        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);
            cameraFollow.FollowDisc(activeDisc);
            playSFX.PlayShootFX();
        }
    }
    void Move()
    {
        // Move the player left and right based on horizontal input
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }
}
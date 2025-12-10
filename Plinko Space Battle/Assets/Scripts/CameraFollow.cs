using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Reference to the camera, player, and disc game objects and lerp rate for smooth movement
    new public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    void FixedUpdate()
    {
        // Determine target position based on disc or player position
        Vector3 targetPosition;
        if (disc == null)
        {
            // Follow the player if the disc is not present
            targetPosition = player.transform.position;
        }
        else
        {
            // Follow the disc if it is present
            targetPosition = disc.transform.position;
        }
        // Keep the camera's z position and center x position
        targetPosition.x = 0;
        targetPosition.z = camera.transform.position.z;

        // Assign camera position part way from current to target position
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);
    }
    public void FollowDisc(GameObject disc)
    {
        // Set the disc to be followed by the camera
        this.disc = disc;
    }
}
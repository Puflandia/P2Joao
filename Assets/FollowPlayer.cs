using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Adjust this to set the desired smoothness

    void LateUpdate()
    {
        if (player != null)
        {
            // Set the camera's position to smoothly interpolate towards the player's position
            Vector3 desiredPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}



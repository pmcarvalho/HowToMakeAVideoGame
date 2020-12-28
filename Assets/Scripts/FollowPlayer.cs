using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // Variable references the player in order to get his position
    public Transform player;
    // Offset makes so the camera isnt inside the player 
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour
{
    public Transform player; // Drag your player object here in the Inspector
    public Vector3 offset; // Adjust this to position the camera relative to the player

    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}


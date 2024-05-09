using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform RedExit; // Exit point for the red portal
    public Transform BlueExit; // Exit point for the blue portal
    public GameObject player; // Reference to the player GameObject

    private void OnTriggerEnter(Collider collider)
    {
        // Check if the player is entering the RedPortal
        if (gameObject.name == "RedPortal")
        {
            player.transform.position = BlueExit.position;
        }

        // Check if the player is entering the BluePortal
        if (gameObject.name == "BluePortal")
        {
            player.transform.position = RedExit.position;
        }
    }
}

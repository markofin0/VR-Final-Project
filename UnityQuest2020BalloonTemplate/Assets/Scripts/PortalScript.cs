using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    // previosly used script, used as reference for blue and red portal scripts
    // poition of red portal
    public Transform RedExit; 
    // position of blue portal
    public Transform BlueExit; 
    // player object
    public GameObject player; 
    // teleport cooldown, can be changed in inspector
    public float teleportCooldown = 1f; 
    // Meta player object
    private OVRPlayerController ovrPlayerController;
    // boolean to determine whether another portal can be spawned
    private bool isOnCooldown = false;

    private void Start()
    {
        
        ovrPlayerController = player.GetComponent<OVRPlayerController>();

    }

    private void OnTriggerEnter(Collider collider)
    {
        // starts coroutine based on what portal is entered
        if (collider.CompareTag("Player") && !isOnCooldown)
        {
            
            if (CompareTag("RedPortal"))
            {
                StartCoroutine(TeleportPlayer(BlueExit));
            }

            
            if (CompareTag("BluePortal"))
            {
                StartCoroutine(TeleportPlayer(RedExit));
            }
        }
    }

    private IEnumerator TeleportPlayer(Transform exitPoint)
    {
        
        if (ovrPlayerController != null)
        {
            ovrPlayerController.enabled = false;
        }

        
        isOnCooldown = true;

        // transforms player based on exit determined by coroutine
        player.transform.position = exitPoint.position;
        player.transform.rotation = exitPoint.rotation;

        // waits for teleport cooldown
        yield return new WaitForSeconds(teleportCooldown);

        
        if (ovrPlayerController != null)
        {
            ovrPlayerController.enabled = true;
        }

        
        isOnCooldown = false;
    }
    private void Update()
    {
        
    }
    
}

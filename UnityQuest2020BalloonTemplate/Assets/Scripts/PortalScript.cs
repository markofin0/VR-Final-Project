using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform RedExit; 
    public Transform BlueExit; 
    public GameObject player; 
    public float teleportCooldown = 1f; 

    private OVRPlayerController ovrPlayerController;
    private bool isOnCooldown = false;

    private void Start()
    {
        
        ovrPlayerController = player.GetComponent<OVRPlayerController>();

    }

    private void OnTriggerEnter(Collider collider)
    {
        
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

        
        player.transform.position = exitPoint.position;
        player.transform.rotation = exitPoint.rotation;

        
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

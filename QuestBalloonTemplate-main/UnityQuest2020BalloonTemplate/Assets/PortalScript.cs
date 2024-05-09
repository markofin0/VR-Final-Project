using System.Collections;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform redExit;
    public Transform blueExit;
    public GameObject player;
    public float teleportCooldown = 1f;

    private OVRPlayerController ovrPlayerController;
    private bool isOnCooldown = false;

    private void Start()
    {
        ovrPlayerController = player.GetComponent<OVRPlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOnCooldown)
        {
            if (CompareTag("RedPortal"))
            {
                StartCoroutine(TeleportPlayer(blueExit));
            }

            if (CompareTag("BluePortal"))
            {
                StartCoroutine(TeleportPlayer(redExit));
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
}

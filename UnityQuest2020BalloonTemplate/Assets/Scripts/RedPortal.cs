using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float teleportCooldown = 1f;
    public Transform blueExit;
    public GameObject OtherRedPrtl;
    public bool isOnCooldown;

    private OVRPlayerController ovrPlayerController;
    void Start()
    {
        // set ovr player controller
        player = GameObject.FindGameObjectWithTag("Player");
        OtherRedPrtl = GameObject.FindGameObjectWithTag("RedPortal");
        // destroys other portal with same tag, due to duplicating portal bug
        Destroy(OtherRedPrtl);
        ovrPlayerController = player.GetComponent<OVRPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        blueExit = GameObject.FindWithTag("BlueExit").transform;
        Debug.Log(blueExit + " Blue");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !isOnCooldown)
        {
            StartCoroutine(TeleportPlayer(blueExit));
        }
    }

    private IEnumerator TeleportPlayer(Transform exitPoint)
    {
        if (ovrPlayerController != null)
        {
            ovrPlayerController.enabled = false;
        }

        isOnCooldown = true;
        // transforms player to new portal position along with rotation
        player.transform.position = exitPoint.position;
        player.transform.rotation = exitPoint.rotation;

        yield return new WaitForSeconds(teleportCooldown);

        if (ovrPlayerController != null)
        {
            ovrPlayerController.enabled = true;
        }

        isOnCooldown = false;
    }
    // OnTriggerEnter see if player collides with portal
    // on collision set rotation and position of player
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePortal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float teleportCooldown = 1f;
    public Transform redExit;
    public GameObject OtherBluePrtl;
    public bool isOnCooldown;

    private OVRPlayerController ovrPlayerController;
    void Start()
    {
        // set ovr player controller
        player = GameObject.FindGameObjectWithTag("Player");
        OtherBluePrtl = GameObject.FindGameObjectWithTag("BluePortal");
        // destroys other portal with same tag, due to duplicating portal bug
        Destroy(OtherBluePrtl);
        ovrPlayerController = player.GetComponent<OVRPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        redExit = GameObject.FindWithTag("RedExit").transform;
        Debug.Log(redExit + " Red");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && !isOnCooldown)
        {
            StartCoroutine(TeleportPlayer(redExit));
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
    // OnTriggerEnter see if player collides with portal
    // on collision set rotation and position of player
}

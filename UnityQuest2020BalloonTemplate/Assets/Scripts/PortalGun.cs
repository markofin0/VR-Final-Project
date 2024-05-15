using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalGun : MonoBehaviour
{

    public GameObject portalBallOne;
    public GameObject portalBallTwo;
    public Transform ballSpawnPoint;
    public float ballSpeed = 5f;
    private bool leftTriggerPressed = false;
    private bool rightTriggerPressed = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    
    void Update()
    {
        float leftTriggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        float rightTriggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch);

        
        if (leftTriggerValue > 0.1f && !leftTriggerPressed)
        {
            ShootOne();
            leftTriggerPressed = true; 
        }
        else if (leftTriggerValue <= 0.1f)
        {
            leftTriggerPressed = false; 
        }

        
        if (rightTriggerValue > 0.1f && !rightTriggerPressed)
        {
            ShootTwo();
            rightTriggerPressed = true; 
        }
        else if (rightTriggerValue <= 0.1f)
        {
            rightTriggerPressed = false; 
        }
    }




    public void ShootOne()
    {


        GameObject blueBall = Instantiate(portalBallOne, ballSpawnPoint.position, ballSpawnPoint.rotation);
        Rigidbody rb = blueBall.GetComponent<Rigidbody>();
        rb.velocity = ballSpawnPoint.up * ballSpeed;


    }

    public void ShootTwo()
    {

        GameObject redBall = Instantiate(portalBallTwo, ballSpawnPoint.position, ballSpawnPoint.rotation);
        Rigidbody rb = redBall.GetComponent<Rigidbody>();
        rb.velocity = ballSpawnPoint.up * ballSpeed;

    }
}


   





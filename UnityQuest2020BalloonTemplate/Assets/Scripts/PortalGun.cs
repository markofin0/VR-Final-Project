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
    AudioSource ballSound;


    // Start is called before the first frame update
    void Start()
    {
        ballSound = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        float leftTriggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        float rightTriggerValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch);

        // shoots RedBullet or BlueBullet depending on trigger used, also deploys audio
        if (leftTriggerValue > 0.1f && !leftTriggerPressed)
        {
            ShootOne();
            leftTriggerPressed = true;
            ballSound.Play();
        }
        else if (leftTriggerValue <= 0.1f)
        {
            leftTriggerPressed = false; 
        }

        
        if (rightTriggerValue > 0.1f && !rightTriggerPressed)
        {
            ShootTwo();
            rightTriggerPressed = true;
            ballSound.Play();
        }
        else if (rightTriggerValue <= 0.1f)
        {
            rightTriggerPressed = false; 
        }
    }




    public void ShootOne()
    {

        // instantiates blueBall, sets values according to variables set in inspector
        GameObject blueBall = Instantiate(portalBallOne, ballSpawnPoint.position, ballSpawnPoint.rotation);
        Rigidbody rb = blueBall.GetComponent<Rigidbody>();
        rb.velocity = ballSpawnPoint.up * ballSpeed;


    }

    public void ShootTwo()
    {
        // instantiates redBall, sets values according to variables set in inspector
        GameObject redBall = Instantiate(portalBallTwo, ballSpawnPoint.position, ballSpawnPoint.rotation);
        Rigidbody rb = redBall.GetComponent<Rigidbody>();
        rb.velocity = ballSpawnPoint.up * ballSpeed;

    }
}


   





using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class companioncube : MonoBehaviour
{
    public bool activated;
    public GameObject redCube;
    public GameObject greenCubePrefab;
    public ScoreManager scoreManager;
    public bool canIncrease = true;
    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("scoreManager").GetComponent<ScoreManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "portalbutton")
        {
            Debug.Log("has collide");
            activated = true;
            Instantiate(greenCubePrefab,redCube.transform.position, Quaternion.identity);
            Debug.Log("Button tag detected. Increasing score.");
            scoreManager.increaseScore();
            canIncrease = false;
        }
        Debug.Log("WORKS");
    }

    

    void OnCollisionEnter(Collision collision)
    {
        //checks to see if the object scollided with has the tag "button"
        if (collision.gameObject.CompareTag("portalbutton") && canIncrease == true)
        {
            //increases the score
            Debug.Log("Button tag detected. Increasing score.");
            scoreManager.increaseScore();
            canIncrease = false;
        }
    }
}

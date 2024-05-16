using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class door2 : MonoBehaviour
{

    public GameObject companionCubeObject;
    public companioncube Companioncube;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        // this is in Update() due to needing to make sure it always has a target, which is grabbing an object with the tag companionCube
        companionCubeObject = GameObject.FindGameObjectWithTag("companionCube");
        Companioncube = companionCubeObject.GetComponent<companioncube>();
        //Debug.Log(Companioncube.activated);
        if (Companioncube != null)
        {
            //Debug.Log("Not null");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Companioncube != null && Companioncube.activated == true)
        {
            // if the player collides with the door while all requirements are met, it loads a new scene
            Debug.Log("Collides!");
            SceneManager.LoadScene("Level2");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && Companioncube != null && Companioncube.activated == true)
        {
            // both OnCollisionEnter and OnTriggerEnter are used here to make sure that this gets executed on whatever frame comes first, may be redundant
            Debug.Log("Collides!");
            SceneManager.LoadScene("Level2");
        }
    }
}
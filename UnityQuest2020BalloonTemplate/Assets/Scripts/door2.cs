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
            Debug.Log("Collides!");
            SceneManager.LoadScene("Level2");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && Companioncube != null && Companioncube.activated == true)
        {
            Debug.Log("Collides!");
            SceneManager.LoadScene("Level2");
        }
    }
}
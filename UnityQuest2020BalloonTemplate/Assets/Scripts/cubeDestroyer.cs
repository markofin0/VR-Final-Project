using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDestroyer : MonoBehaviour
{
    public GameObject companionCube;
    public GameObject cubeSpawn;
    // Start is called before the first frame update
    private void Start()
    {
        // sets object with tag companionCube to a GameObject variable
        companionCube = GameObject.FindGameObjectWithTag("companionCube");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "companionCube")
        {
            // gives illusion of being destoryed, really just transforms to new spawn locator (cube generator)
            companionCube.transform.position = cubeSpawn.transform.position;
            Debug.Log("destroyed cube");
        }
    }
}

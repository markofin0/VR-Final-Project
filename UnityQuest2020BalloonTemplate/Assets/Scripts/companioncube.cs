using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companioncube : MonoBehaviour
{
    public bool activated;
    public GameObject redCube;
    public GameObject greenCubePrefab;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "portalbutton")
        {
            Debug.Log("has collide");
            activated = true;
            Instantiate(greenCubePrefab,redCube.transform.position, Quaternion.identity);
        }
        Debug.Log("WORKS");
    }
}

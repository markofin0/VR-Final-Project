using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class companioncube : MonoBehaviour
{
    public bool activated;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "portalbutton")
        {
            Debug.Log("has collide");
            activated = true;
        }
        Debug.Log("WORKS");
    }
}

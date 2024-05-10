using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBullet : MonoBehaviour
{
    public GameObject prefabToDuplicate;
    public GameObject originalObject;
    public bool matchRotationToSurface = true;
    public GameObject objectToDestroy;
    private void Start()
    {
        // start method to destroy previous portal 
        objectToDestroy = GameObject.FindGameObjectWithTag("BluePortal");
        Destroy(objectToDestroy);
        Debug.Log("Destoryed start");

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("Collides");
        // sets position of portal
        ContactPoint contact = collision.contacts[0];
        Vector3 collisionPoint = contact.point;
        Vector3 collisionNormal = contact.normal;
        

        // sets rotation of portal
        Quaternion rotation;
        if (matchRotationToSurface)
        {
            rotation = Quaternion.LookRotation(collisionNormal);
        }
        else
        {
            rotation = originalObject.transform.rotation;
        }

        // instantiates new portal
        Instantiate(prefabToDuplicate, collisionPoint, rotation);
        Debug.Log("Instantiated");

        // destorys bullet
        Debug.Log("Destroyed");
        Destroy(gameObject);
        Debug.Log("Destroyed B");
    }
}
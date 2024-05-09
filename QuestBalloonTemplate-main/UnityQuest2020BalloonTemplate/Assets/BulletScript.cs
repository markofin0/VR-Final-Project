using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject prefabToDuplicate; 
    public GameObject originalObject; 
    public bool matchRotationToSurface = true;
    public GameObject objectToDestroy;

    private void OnCollisionEnter(Collision collision)
    {
        
        ContactPoint contact = collision.contacts[0];
        Vector3 collisionPoint = contact.point;
        Vector3 collisionNormal = contact.normal;

        
        Quaternion rotation;
        if (matchRotationToSurface)
        {
            rotation = Quaternion.LookRotation(collisionNormal);
        }
        else
        {
            rotation = originalObject.transform.rotation;
        }

        
        Instantiate(prefabToDuplicate, collisionPoint, rotation);

        Destroy(objectToDestroy);
        Destroy(gameObject);
        
    }
}

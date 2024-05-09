using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject prefabToDuplicate;
    public bool matchRotationToSurface = true;

    private GameObject previousPortal;

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
            rotation = transform.rotation;
        }

        // Check if the bullet is blue or red
        string bulletColor = gameObject.tag; // Assuming bullet color is determined by its tag

        // Find and destroy the previous portal if it matches the bullet color
        GameObject[] portals = GameObject.FindGameObjectsWithTag(bulletColor + "portal");
        foreach (GameObject portal in portals)
        {
            if (portal != null && portal != previousPortal)
            {
                Destroy(portal);
            }
        }

        // Instantiate the new portal
        GameObject newPortal = Instantiate(prefabToDuplicate, collisionPoint, rotation);
        previousPortal = newPortal;

        // Destroy the bullet itself
        Destroy(gameObject);
    }
}


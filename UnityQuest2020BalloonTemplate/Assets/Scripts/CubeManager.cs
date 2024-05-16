using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Michael
public class CubeManager: MonoBehaviour
{
    public ScoreManager scoreManager;
    public bool canIncrease = true;
    
    void OnCollisionEnter(Collision collision)
    {
        //checks to see if the object scollided with has the tag "button"
        if (collision.gameObject.CompareTag("Button") && canIncrease == true)
        {
            //increases the score
            Debug.Log("Button tag detected. Increasing score.");
            scoreManager.increaseScore();
            canIncrease = false;
        }
    }
}

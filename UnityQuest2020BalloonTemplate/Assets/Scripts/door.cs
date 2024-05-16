using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class door : MonoBehaviour
{

    public GameObject companionCubeObject;
    private companioncube companionCube;

    // Start is called before the first frame update
    void Start()
    {
        companionCube = companionCubeObject.GetComponent<companioncube>();
    }
    private void Update()
    {
        if (companionCube != null)
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && companionCube != null && companionCube.activated == true)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}

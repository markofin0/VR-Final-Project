using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGenerator : MonoBehaviour
{
    public GameObject cubeprefab;
    public GameObject cubeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SpawnCube()
    {
        // instantiates a cube prefab of choice in inspector at the location of a empty game object in scene
        Instantiate(cubeprefab, cubeSpawn.transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

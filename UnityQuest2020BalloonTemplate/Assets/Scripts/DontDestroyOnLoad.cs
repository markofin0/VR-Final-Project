using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // used for all objects that are not wanted to be destroyed in between loading scenes
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

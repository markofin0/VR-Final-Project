using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchScene()
    {
        // switches scene to first level, method called on button press in BaseScene.unity
        SceneManager.LoadScene("LevelOne");
    }
}

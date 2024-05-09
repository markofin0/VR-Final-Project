using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadLevel1", 10f);
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("Level1"); 
    }
}
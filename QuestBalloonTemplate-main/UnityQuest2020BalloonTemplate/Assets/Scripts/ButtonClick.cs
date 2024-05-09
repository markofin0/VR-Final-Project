using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.onClick.AddListener(LoadLevel1);
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
}
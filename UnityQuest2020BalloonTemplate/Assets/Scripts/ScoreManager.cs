using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public int scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void increaseScore()
    {
        Debug.Log("increased score");
        scoreKeeper++;
        UpdateDisplay();

    }

    public void UpdateDisplay()
    {
        scoreText.text = "score: " + scoreKeeper;

    }
}

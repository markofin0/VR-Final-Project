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
        // method to increase score variable
        Debug.Log("increased score");
        scoreKeeper++;
        UpdateDisplay();

    }

    public void UpdateDisplay()
    {
        // method to display score change
        scoreText.text = "score: " + scoreKeeper;

    }
}

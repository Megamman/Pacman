using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    private static string text;
    public static int scoreValue = 0;
    Text score;
    Text highScore;

	// Use this for initialization
	void Start () {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.GetInt("HighScore", scoreValue);
                highScore.text = "High Score: " + scoreValue;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject Game;
    public GameObject Mainmenu;
    public GameObject Pausemenu;

	void OnEnable()
	{
		Time.timeScale = 1f;
		Debug.Log ("enabled");
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Game.SetActive(false);
                Mainmenu.SetActive(true);
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Resume()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}

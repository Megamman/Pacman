using UnityEngine;

public class GameControlScript : MonoBehaviour {

    public GameObject live1, live2, live3, gameOver, pacman;
    public static int lives;

	// Use this for initialization
	void Start () {
        lives = 3;
        live1.gameObject.SetActive (true);
        live2.gameObject.SetActive (true);
        live3.gameObject.SetActive (true);
        gameOver.gameObject.SetActive (false);
    }
	
	// Update is called once per frame
	void Update () {
        if (lives > 3)
            lives = 3;

        switch (lives)
        {
            case 3:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(true);
                live3.gameObject.SetActive(true);
                break;
            case 2:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(true);
                live3.gameObject.SetActive(false);
                break;
            case 1:
                live1.gameObject.SetActive(true);
                live2.gameObject.SetActive(false);
                live3.gameObject.SetActive(false);
                break;
            case 0:
                live1.gameObject.SetActive(false);
                live2.gameObject.SetActive(false);
                live3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
				Destroy(pacman);
                Time.timeScale = 0;
                break;
        }
	}
}

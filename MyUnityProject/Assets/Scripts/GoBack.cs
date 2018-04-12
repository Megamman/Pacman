using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoBack : MonoBehaviour {

	public GameObject TurnFalse;
	public GameObject TurnTrue;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {

            // resets map
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // resets points
            PointsController.scoreValue = 0;
            Time.timeScale = 1;

            // change objects active
            TurnFalse.SetActive(false);
			TurnTrue.SetActive(true);

		}
		
	}
}

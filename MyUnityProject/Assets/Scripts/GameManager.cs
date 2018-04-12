using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// allows an instanse to call from the GameManager al of its functions
	public static GameManager instance = null;

    // Use this for initialization
    void Awake () {

		// if instance is not initialized
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}

}

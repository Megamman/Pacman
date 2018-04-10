using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman")
		{
			// This comand will add +1 to the Score Counter
			FindObjectOfType<PointsController>().AddScore(50);	

			// Destroy the object
			Destroy (gameObject);
		}
	}
}

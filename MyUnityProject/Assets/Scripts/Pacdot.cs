using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman")
		{
			// This comand will add +1 to the Score Counter
			FindObjectOfType<PointsController>().AddScore(10);	

			// Destroy the object
			Destroy (gameObject);
		}
	}
}

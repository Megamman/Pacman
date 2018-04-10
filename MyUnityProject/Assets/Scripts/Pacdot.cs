using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman")
			// Destroy the object
			Destroy(gameObject);

			// This comand will add +1 to the Score Counter
			PointsController.scoreValue += 10;
	}
}

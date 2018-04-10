using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject Point;
	public GameObject Point2;

	// Use this for initialization
	void Start () {

		Point.SetActive(true);
		Point2.SetActive(false);

		//Debug.Log("Active Self: " + Point.activeSelf);
		//Debug.Log("Active in Heirarchy" + Point.activeInHeirarchy);

	}

	void OnTriggerEnter() {
		Point.SetActive(false);
		Point2.SetActive(true);
	}

}

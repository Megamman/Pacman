using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostIntro : MonoBehaviour {
	public Transform[] introWaypoints;
	public Transform[] startWaypoints;
	int cur = 0;
	int phase = 0;

	public float speed = 0.3f;

	void Start()
	{
		Invoke ("ToPhaseOne", 2f);
	}

	void FixedUpdate () {
		if (phase == 0)
		{
			if (transform.position.Equals (introWaypoints [cur].position))
			{
				// if condition on one line - switch between 1 and 0.
				cur = (cur == 0) ? 1 : 0;
			}
			transform.position = Vector2.MoveTowards (transform.position, introWaypoints [cur].position, speed);
		}

		if (phase == 1)
		{
			if (transform.position.Equals (startWaypoints [cur].position)) {
				cur++;
				if (cur == 2) {
					this.enabled = false;
				}
			} else {
				transform.position = Vector2.MoveTowards (transform.position, startWaypoints [cur].position, speed);
			}
		}
	}

	void ToPhaseOne()
	{
		phase = 1;
		cur = 0;
	}
}

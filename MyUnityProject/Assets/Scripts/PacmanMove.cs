using System.Collections;
using UnityEngine;

public class PacmanMove : MonoBehaviour {
	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;

	// Use this for initialization
	void Start () {
		dest = transform.position;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.A)) {
			SetDirection (Vector2.left);
		}

		if (Input.GetKey (KeyCode.D)) {
			SetDirection (Vector2.right);
		}

		if (Input.GetKey (KeyCode.W)) {
			SetDirection (Vector2.up);
		}

		if (Input.GetKey (KeyCode.S)) {
			SetDirection (Vector2.down);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// Move closer to Destination
		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);

		/*
		// Check for Input if not moving
		if ((Vector2)transform.position == dest) {
			if (Input.GetKey(KeyCode.W) && valid(Vector2.up))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey(KeyCode.D) && valid(Vector2.right))
				dest = (Vector2)transform.position + Vector2.right;
			if (Input.GetKey(KeyCode.S) && valid(-Vector2.up))
				dest = (Vector2)transform.position - Vector2.up;
			if (Input.GetKey(KeyCode.A) && valid(-Vector2.right))
				dest = (Vector2)transform.position - Vector2.right;
		}
		*/

		// Animation Parameters
		Vector2 dir = dest - (Vector2)transform.position;
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);

	}

	bool valid(Vector2 dir) {
		// Cast Line from 'next to Pac-Man' to 'Pac-Man'
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos, pos + dir);
		return (hit.collider == GetComponent<Collider2D>());
	}

	void SetDirection(Vector2 dir)
	{
		RaycastHit2D hit = Physics2D.Raycast (transform.position, dir, 50f, 1 << LayerMask.NameToLayer("Maze"));

		if (hit != null)
		{
			dest = hit.point - (dir / 2);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour {

	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;
	Rigidbody2D rb2d;
	Animator anim;
	Vector2 direction;

	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}

	// Use this for initialization
	void Start () {
		Vector2 pos = transform.position;
		dest = pos - Vector2.left;
	}

	// Update is called once per frame
	void FixedUpdate () {
		// Move closer to Destination
		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		rb2d.MovePosition(p);
		if (p == dest) {
			List<Vector2> directions = new List<Vector2> (){ Vector2.left, Vector2.right, Vector2.up, Vector2.down };
			directions.Remove (direction);

			valid (directions [Random.Range (0, directions.Count)]);
		}

		// Animation Parameters
		Vector2 dir = dest - (Vector2)transform.position;
		anim.SetFloat("DirX", dir.x);
		anim.SetFloat("DirY", dir.y);

	}

	void valid(Vector2 dir) {
		// linecast from ghost to direction (left, right, etc)
		// where the linecast ends, it's the wall, dest = wall

		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos, pos + (dir * 100f), 1 << LayerMask.NameToLayer("Walls"));
		if (hit) {
			dest = hit.point - (dir * 0.52f);
			direction = dir;
		}

        /*
		Vector2 randomDirection = new Vector2(Random.value, Random.value);
		transform.Rotate(randomDirection);
		return (hit.collider == GetComponent<Collider2D>());
		*/
    }


}


using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// only do stuff if hit by a Enemy
		if (newCollision.gameObject.tag == "Enemy") {
			
			// if game manager exists, make adjustments based on target properties
			if (GameManager.gm) {
				GameManager.gm.playerHit ();
			}
				
			// destroy the Enemy
			Destroy (newCollision.gameObject);
		}
	}
}

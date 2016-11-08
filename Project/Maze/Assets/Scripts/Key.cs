using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public int worth = 1;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Movement2D player = otherCollider.gameObject.GetComponent<Movement2D>();
		if (player != null) {
			KeyCounterScript.score += worth;
			Destroy (gameObject);

		}

	}

	void Start()
	{
		// 2 - Limited time to live to avoid any leak
		// Destroy(gameObject, 20); // 20sec
	}
}

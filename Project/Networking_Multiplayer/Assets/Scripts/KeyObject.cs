using UnityEngine;
using System.Collections;

public class KeyObject : MonoBehaviour {
	/*void Update(Collision collision)
	{
		
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if (health  != null)
			{
				health.TakeDamage(1);
			}

			Destroy(gameObject);
		}
	}*/

	void OnCollisionEnter(Collision collision)
	{
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (health  != null)
		{
			health.TakeDamage(1);
		}

		Destroy(gameObject);
	}
	void OnTriggerEnter2D (Collision collision)
	{
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (health  != null)
		{
			health.TakeDamage(1);
		}

		Destroy(gameObject);
	}

}

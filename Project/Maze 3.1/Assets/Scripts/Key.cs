using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = this.gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();

		Debug.Log(keyName);
		if (player != null)
		{
			if (keyName == "testKeyN")
			{
				MoveKey.MovingTheKey = true;
			}


		}

		if (player2 != null)
		{
			if (keyName == "testKeyN")
			{
				MoveKey.MovingTheKey2 = true;
			}

		}
		if (player != null)
		{
			if (keyName == "Circle")
			{
				MoveKey.MovingTheKey = true;
			}


		}

		if (player2 != null)
		{
			if (keyName == "Circle")
			{
				MoveKey.MovingTheKey2 = true;
			}

		}

	}
}
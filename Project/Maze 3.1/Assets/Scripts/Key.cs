using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = this.gameObject.name;
        Debug.Log("KEY 1111111111111");
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();

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
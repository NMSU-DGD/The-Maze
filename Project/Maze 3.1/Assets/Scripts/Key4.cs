using UnityEngine;
using System.Collections;

public class Key4 : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		//string keyName = this.gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();

		if (player != null)
		{
			//  if (keyName == "Triangle")
			//  {
			MoveKey4.MovingTheKey = true;
			//  }


		}

		if (player2 != null)
		{
			//if (keyName == "Triangle")
			// {
			MoveKey4.MovingTheKey2 = true;
			//   }

		}
	}
}
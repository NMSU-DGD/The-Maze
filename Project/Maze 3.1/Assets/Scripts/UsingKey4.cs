using UnityEngine;
using System.Collections;

public class UsingKey4 : MonoBehaviour
{

	public static bool useTheKey = true;
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		MoveKey4 key1 = otherCollider.gameObject.GetComponent<MoveKey4>();
		if (key1 != null)
		{
			MoveKey4.MovingTheKey = false;
			GameObject.Find("Door18").GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find("Door18").GetComponent<BoxCollider2D>().enabled = false;
			useTheKey = false;
			GameObject.Find("BlackCover02.5").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("Lock02.5").GetComponent<SpriteRenderer>().enabled = false;
		}

	}

}

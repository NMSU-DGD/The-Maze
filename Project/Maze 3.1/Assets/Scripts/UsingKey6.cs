using UnityEngine;
using System.Collections;

public class UsingKey6 : MonoBehaviour
{
    GameObject circle;
	public static bool useTheKey = true;
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
        circle = GameObject.Find("Circle2");
        MoveKey6 key1 = otherCollider.gameObject.GetComponent<MoveKey6>();
		if (key1 != null)
		{
            circle.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey6.MovingTheKey = false;
			GameObject.Find("Door06").GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find("Door06").GetComponent<BoxCollider2D>().enabled = false;
			useTheKey = false;

		}

	}

}
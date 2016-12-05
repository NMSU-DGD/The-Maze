using UnityEngine;
using System.Collections;

public class UsingKey : MonoBehaviour {

    GameObject circle;
	public static bool useTheKey = true;
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
        circle = GameObject.Find("Circle");
        MoveKey key1 = otherCollider.gameObject.GetComponent<MoveKey>();
		if (key1 != null)
		{
            circle.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey.MovingTheKey = false;
			KeyCounterScript.score -= 1;
			GameObject.Find("Door03").GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find("Door03").GetComponent<BoxCollider2D>().enabled = false;
			useTheKey = false;
		}

	}

}

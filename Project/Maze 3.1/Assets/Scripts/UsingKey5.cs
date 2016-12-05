using UnityEngine;
using System.Collections;

public class UsingKey5 : MonoBehaviour
{
    GameObject cloud;
	public static bool useTheKey = true;
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
        cloud = GameObject.Find("Cloud2");
        MoveKey5 key1 = otherCollider.gameObject.GetComponent<MoveKey5>();
		if (key1 != null)
		{
            cloud.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey5.MovingTheKey = false;
			GameObject.Find("Door08").GetComponent<MeshRenderer>().enabled = false;
			GameObject.Find("Door08").GetComponent<BoxCollider2D>().enabled = false;
			useTheKey = false;
		
		}

	}

}

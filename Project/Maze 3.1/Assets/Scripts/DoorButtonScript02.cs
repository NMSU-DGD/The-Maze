using UnityEngine;
using System.Collections;

public class DoorButtonScript02 : MonoBehaviour {


	PlayerMovement player;
	PlayerMovement02 player2;
    Box box;
	public static bool d42 = false;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		box = otherCollider.gameObject.GetComponent<Box>();
		if (box!=null || player != null || player2 != null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = true;
			}

		}
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		box = otherCollider.gameObject.GetComponent<Box>();

		Debug.Log(player);
        if (box != null || player != null || player2 != null)
        {
			if (keyName == "DoorButton04.2")
			{
				d42 = false;
				GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = true;
				GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = true;
			}
		}

	}
}


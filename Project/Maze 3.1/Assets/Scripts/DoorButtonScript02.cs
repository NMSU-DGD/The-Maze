using UnityEngine;
using System.Collections;

public class DoorButtonScript02 : MonoBehaviour {


	PlayerMovement player;
	PlayerMovement02 player2;
	MoveBox box;
	public static bool d42 = false;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		box = otherCollider.gameObject.GetComponent<MoveBox>();
		if (box!=null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = true;
			}

		}
		if (player !=null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = true;
			}

		}
		if (player2 !=null) {
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
		box = otherCollider.gameObject.GetComponent<MoveBox>();

		Debug.Log(player);
		if (box!=null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = false;
				GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = true;
				GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = true;
			}
		}
		if (player!=null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = false;
				GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = true;
				GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = true;
			}
		}
		if (player2!=null) {
			if (keyName == "DoorButton04.2")
			{
				d42 = false;
				GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = true;
				GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = true;
			}
		}

	}
}


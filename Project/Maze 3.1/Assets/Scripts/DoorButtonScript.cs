using UnityEngine;
using System.Collections;

public class DoorButtonScript : MonoBehaviour {


	PlayerMovement player;
	PlayerMovement02 player2;
	Box box;

	bool d41 = false;
	void FixedUpdate()
	{
		if (d41 && DoorButtonScript02.d42) {
			Debug.Log ("Door open button door");
			GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = false;
			GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		box = otherCollider.gameObject.GetComponent<Box>();

		if (player != null || player2 != null|| box!=null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = false;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor02").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor02").GetComponent<BoxCollider2D>().enabled = false;
			}

			if (keyName == "DoorButton03")
			{
				GameObject.Find("ButtonDoor03").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor03").GetComponent<BoxCollider2D>().enabled = false;
			}

			if (keyName == "DoorButton05")
			{
				GameObject.Find("ButtonDoor05").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor05").GetComponent<BoxCollider2D>().enabled = false;
			}

			if (keyName == "DoorButton04.1")
			{
				d41 = true;
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
		if (player != null || player2 != null|| box!=null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = true;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor02").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor02").GetComponent<BoxCollider2D>().enabled = true;
			}

			if (keyName == "DoorButton04.1")
			{
				d41 = false;
				GameObject.Find ("ButtonDoor04").GetComponent<MeshRenderer> ().enabled = true;
				GameObject.Find ("ButtonDoor04").GetComponent<BoxCollider2D> ().enabled = true;
			}

			if (keyName == "DoorButton03")
			{
				GameObject.Find("ButtonDoor03").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor03").GetComponent<BoxCollider2D>().enabled = true;
			}

			if (keyName == "DoorButton05")
			{
				GameObject.Find("ButtonDoor05").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor05").GetComponent<BoxCollider2D>().enabled = true;
			}

		}

	}
}


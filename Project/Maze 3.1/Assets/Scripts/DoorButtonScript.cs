using UnityEngine;
using System.Collections;

public class DoorButtonScript : MonoBehaviour {


	PlayerMovement player;
	PlayerMovement02 player2;


	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
        Debug.Log(player);
		if (player != null || player2 != null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = false;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = false;
			}

		}

	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		Debug.Log(player);
		if (player != null || player2 != null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = true;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor").GetComponent<BoxCollider2D>().enabled = true;
			}

		}

	}
}


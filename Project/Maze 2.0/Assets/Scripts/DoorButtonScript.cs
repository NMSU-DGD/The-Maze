using UnityEngine;
using System.Collections;

public class DoorButtonScript : MonoBehaviour {


	Movement2D player;


	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<Movement2D>();

        Debug.Log(player);
        if (player != null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor01").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor01").GetComponent<BoxCollider2D>().enabled = false;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor02").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("ButtonDoor02").GetComponent<BoxCollider2D>().enabled = false;
			}

		}

	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<Movement2D>();
		if (player != null) {
			if (keyName == "DoorButton")
			{
				GameObject.Find("ButtonDoor01").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor01").GetComponent<BoxCollider2D>().enabled = true;
			}
			if (keyName == "DoorButton02")
			{
				GameObject.Find("ButtonDoor02").GetComponent<MeshRenderer>().enabled = true;
				GameObject.Find("ButtonDoor02").GetComponent<BoxCollider2D>().enabled = true;
			}

		}

	}
}


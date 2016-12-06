using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenLevel2 : MonoBehaviour {
	PlayerMovement player;
	PlayerMovement02 player2;
	public GameObject canvasPrefab;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		if (player != null) {
			if (keyName == "End2") {
				Debug.Log("End");
				Vector3 temp = new Vector3(-6.76f,2.26f,-1.0f);
				GameObject.FindGameObjectWithTag ("player1").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
			if (keyName == "End1") {
				Debug.Log("End1");
				Vector3 temp = new Vector3(-6.76f,2.26f,-1.0f);
				GameObject.FindGameObjectWithTag ("player1").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
		if (player2 != null) {
			if (keyName == "End2") {
				Debug.Log("End");
				Vector3 temp = new Vector3(-6.76f,0.91f,-1.0f);
				GameObject.FindGameObjectWithTag ("player2").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
		if (player2 != null) {
			if (keyName == "End1") {
				Debug.Log("End1");
				Vector3 temp = new Vector3(-6.76f,0.91f,-1.0f);
				GameObject.FindGameObjectWithTag ("player2").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
}
	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		if (player != null || player2 != null) {
			if (keyName == "End2") {
				Debug.Log("End");
				GameObject.Find("Level02").GetComponent<SpriteRenderer>().enabled = true;
				GameObject.Find("BlackCover02").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("Lock02").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("Level2Door").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("Level2Door").GetComponent<BoxCollider2D>().enabled = false;
				GameObject.Find("Level01.1").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("BlackCover02.5").GetComponent<SpriteRenderer>().enabled = true;
				GameObject.Find("Lock02.5").GetComponent<SpriteRenderer>().enabled = true;
				GameObject.Find("Level02").GetComponent<SpriteRenderer>().enabled = true;


				Destroy(GameObject.FindWithTag("TimeBar01"));
				GameObject newCanvas = (GameObject)Instantiate (canvasPrefab, transform.position, transform.rotation);
				GameObject.Find("Center").GetComponent<Image>().enabled = false;
				GameObject.Find("Center").GetComponent<Image>().enabled = false;
				GameObject.Find("Center (1)").GetComponent<Image>().enabled = true;
				GameObject.Find("Center (2)").GetComponent<Image>().enabled = true;

			}
		}
		if (player != null || player2 != null) {
			if (keyName == "End1") {
				Debug.Log("End1");
				GameObject.Find("Level01.1").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("Level02").GetComponent<SpriteRenderer>().enabled = true;
				GameObject.Find("BlackCover02").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("Lock02").GetComponent<SpriteRenderer>().enabled = false;
				GameObject.Find("Level2Door").GetComponent<MeshRenderer>().enabled = false;
				GameObject.Find("Level2Door").GetComponent<BoxCollider2D>().enabled = false;
				GameObject.Find("BlackCover02.5").GetComponent<SpriteRenderer>().enabled = true;
				GameObject.Find("Lock02.5").GetComponent<SpriteRenderer>().enabled = true;
				Destroy(GameObject.FindWithTag("TimeBar01"));
				GameObject newCanvas = (GameObject)Instantiate (canvasPrefab, transform.position, transform.rotation);
				GameObject.Find("Center").GetComponent<Image>().enabled = false;
				GameObject.Find("Center").GetComponent<Image>().enabled = false;

				GameObject.Find("Center (1)").GetComponent<Image>().enabled = true;
				GameObject.Find("Center (2)").GetComponent<Image>().enabled = true;
			}
		}
	}
}
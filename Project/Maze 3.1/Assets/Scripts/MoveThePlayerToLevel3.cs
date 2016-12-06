using UnityEngine;
using System.Collections;

public class MoveThePlayerToLevel3 : MonoBehaviour {
	PlayerMovement player;
	PlayerMovement02 player2;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		if (player != null) {
			if (keyName == "EndToLevel3") {
				Debug.Log("EndToLevel3");
				Vector3 temp = new Vector3(24.25f,4.1f,-1.0f);
				GameObject.FindGameObjectWithTag ("player1").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}	
		if (player2 != null) {
			if (keyName == "EndToLevel3") {
				Debug.Log("EndToLevel3");
				Vector3 temp = new Vector3(24.25f,4.1f,-1.0f);
				GameObject.FindGameObjectWithTag ("player2").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
	}
//	void OnTriggerExit2D(Collider2D otherCollider)
//	{
//		string keyName = gameObject.name;
//		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
//		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
//		if (player != null || player2 != null) {
//			if (keyName == "End2") {
//				Debug.Log("End");
//				GameObject.Find("Level02").GetComponent<SpriteRenderer>().enabled = true;
//				GameObject.Find("BlackCover02").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("Lock02").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("Level2Door").GetComponent<MeshRenderer>().enabled = false;
//				GameObject.Find("Level2Door").GetComponent<BoxCollider2D>().enabled = false;
//				GameObject.Find("Level01.1").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("BlackCover02.5").GetComponent<SpriteRenderer>().enabled = true;
//				GameObject.Find("Lock02.5").GetComponent<SpriteRenderer>().enabled = true;
//
//			}
//		}
//		if (player != null || player2 != null) {
//			if (keyName == "End1") {
//				Debug.Log("End1");
//				GameObject.Find("Level01.1").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("Level02").GetComponent<SpriteRenderer>().enabled = true;
//				GameObject.Find("BlackCover02").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("Lock02").GetComponent<SpriteRenderer>().enabled = false;
//				GameObject.Find("Level2Door").GetComponent<MeshRenderer>().enabled = false;
//				GameObject.Find("Level2Door").GetComponent<BoxCollider2D>().enabled = false;
//				GameObject.Find("BlackCover02.5").GetComponent<SpriteRenderer>().enabled = true;
//				GameObject.Find("Lock02.5").GetComponent<SpriteRenderer>().enabled = true;
//			}
//		}
//	}
}
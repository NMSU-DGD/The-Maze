using UnityEngine;
using System.Collections;

public class FinishLevel3 : MonoBehaviour {
	PlayerMovement player;
	PlayerMovement02 player2;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		if (player != null) {
			if (keyName == "End3") {
				Debug.Log("End");
				Vector3 temp = new Vector3(-6.76f,2.26f,-1.0f);
				GameObject.FindGameObjectWithTag ("player1").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
		if (player2 != null) {
			if (keyName == "End3") {
				Debug.Log("End");
				Vector3 temp = new Vector3(-6.76f,0.91f,-1.0f);
				GameObject.FindGameObjectWithTag ("player2").GetComponent<SpriteRenderer> ().transform.position = temp;
			}
		}
	}
}
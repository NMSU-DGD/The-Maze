using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collide : MonoBehaviour {
	public static int MaxNumbers=0;
	public Text Code;
	public GameObject KeyPad = null;
	public bool showing = false;


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			KeyPad.active = true;
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
		KeyPad.active = false;
		if (player != null || player2 != null) {
			if (keyName == "t(1)")
			{
				KeyPad.active = false;
				//Vector3 temp2 = new Vector3(2.27f,2.28f,0.5f);
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.localScale = temp2;
				//Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.position -= temp;
				//Debug.Log("Plan");
				//GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
				//GameObject.Find("Planningmap").GetComponent<Camera>().enabled = false;
			}

		}

	}

//
//	public void Update()
//	{
//		if (Input.GetKeyDown (KeyCode.K) && showing == false) {
//			showing = true;
//			if (KeyPad != null) {
//				KeyPad.active = true;
//			}
//		} 	else if (Input.GetKeyDown (KeyCode.Escape) && showing == true) {
//			showing = false;
//			if (KeyPad != null && Code!= null) {
//
//				Code.text = "";
//				KeyPadSystem.MaxNumbers=0;
//				KeyPad.active = false;
//			}
//		}
//	}


}

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
		Movement2D player = otherCollider.gameObject.GetComponent<Movement2D> ();
			Debug.Log("ok");
			KeyPad.active = true;
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		string keyName = gameObject.name;
		Movement2D player = otherCollider.gameObject.GetComponent<Movement2D>();
		if (player != null) {
			if (keyName == "t")
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

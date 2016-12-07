using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Activate : MonoBehaviour {

	public Image button;
	public Text Code;
	public Color Hover;
	public Color Original;
	public String scene;
	public GameObject KeyPad = null;
	GameObject theHolder;
	//public bool extraTime = false;
	//TimeBar extra;

	void Start()
	{
		theHolder = GameObject.Find ("Holder");
	}
	public void OnMouseEnter()
	{
		button.color = Hover;
	}

	public void OnMouseExit()
	{
		button.color = Original;
	}

	public void OnMouseDown()
	{
		if (Code.text == "5735") {//scheking if typing count number is correct
			GameObject.Find("BlackCover01").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("Lock01").GetComponent<SpriteRenderer>().enabled = false;
			Debug.Log ("Correct");
			PlayerMovement player = gameObject.GetComponent<PlayerMovement> ();
			PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			Destroy(GameObject.FindWithTag("Door1"));
			Destroy(GameObject.FindWithTag("keypad1"));
			theHolder.active = false;
			//Destroy(GameObject.FindWithTag("Keypad"));
			//Application.LoadLevel (scene);
			//TimeBar.extraTime(10);
			//add time

		} 
		if (Code.text == "2340") {//cheking if typing count number is correct
			Debug.Log ("Correct");
			PlayerMovement player = gameObject.GetComponent<PlayerMovement> ();
			PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			Destroy(GameObject.FindWithTag("Door17"));
		//	KeyPad.active = false;
		//	Debug.Log ("SULTAN ALHARTHI");
			Destroy(GameObject.FindWithTag("keypad2"));
			theHolder.active = false;
			//Destroy(GameObject.FindWithTag("Keypad"));
			//Application.LoadLevel (scene);

		}
		if (Code.text == "1560") {//cheking if typing count number is correct
			Debug.Log ("Correct");
			PlayerMovement player = gameObject.GetComponent<PlayerMovement> ();
			PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			Destroy(GameObject.FindWithTag("Door19"));
			//KeyPad.active = false;
			Destroy(GameObject.FindWithTag("keypad3"));
			theHolder.active = false;
			//Destroy(GameObject.FindWithTag("Keypad"));
			//Application.LoadLevel (scene);

		}
		else { //if code is incorrect

			Code.text = "";
			KeyPadSystem.MaxNumbers = 0;
			Debug.Log ("Incorrect");
		}
	}
}

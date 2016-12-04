﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Activate : MonoBehaviour {

	public Image button;
	public Text Code;
	public Color Hover;
	public Color Original;
	public String scene;

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
		if (Code.text == "5") {//cheking if typing count number is correct
			GameObject.Find("BlackCover01").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("Lock01").GetComponent<SpriteRenderer>().enabled = false;
			Debug.Log ("Correct");
			PlayerMovement player = gameObject.GetComponent<PlayerMovement> ();
			PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			Destroy(GameObject.FindWithTag("Door1"));
			Destroy(GameObject.FindWithTag("Keypad"));
			//Application.LoadLevel (scene);

		} 
		if (Code.text == "7") {//cheking if typing count number is correct
			Debug.Log ("Correct");
			PlayerMovement player = gameObject.GetComponent<PlayerMovement> ();
			PlayerMovement02 player2 = gameObject.GetComponent<PlayerMovement02> ();
			Debug.Log("ok");
			Destroy(GameObject.FindWithTag("Door17"));
			Destroy(GameObject.FindWithTag("Keypad"));
			//Application.LoadLevel (scene);

		} else { //if code is incorrect

			Code.text = "";
			KeyPadSystem.MaxNumbers = 0;
			Debug.Log ("Incorrect");
		}
	}
}

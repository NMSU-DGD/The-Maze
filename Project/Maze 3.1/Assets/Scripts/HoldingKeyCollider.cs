using UnityEngine;
using System.Collections;

public class HoldingKeyCollider : MonoBehaviour {

//	public bool showing = false;
//	public GameObject PressPad;
//	public GameObject ReleasePad;
//	public int p;
//	public bool holding = false;
//	public string keyName;
//
//	void OnTriggerEnter2D(Collider2D otherCollider)
//	{
//
//	    keyName = this.gameObject.name;
//		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
//		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
//		ReleasePad.active = false;
//		if (player != null && holding==false)
//		{
//			if (keyName == "Cloud")
//			{
//				PressPad.active = true;
//				p = 1;
//				Debug.Log ("keyName");
//
//			}
//
//		}
//
//		if (player2 != null && holding==false)
//		{
//			if (keyName == "Cloud")
//			{
//				PressPad.active = true;
//				p = 2;
//
//			}
//		}
//	}
//
//	void OnTriggerExit2D(Collider2D otherCollider)
//	{
//		
//		PressPad.active = false;
//		ReleasePad.active = false;
//
//	}
//	// Update is called once per frame
//	void Update () {
//			///Release the key with P key
//		 string keyName = this.gameObject.name;
//		Debug.Log ("keyName");
//			if (Input.GetKeyDown (KeyCode.P) && p==1 && holding==false) 
//			{
//
//				MoveKey.MovingTheKey = true;
//				holding = true;
//				PressPad.active = false;
//				ReleasePad.active = true;
//
//			}
//			if (Input.GetKeyDown (KeyCode.P) && p==2 && holding==false) 
//			{
//
//				MoveKey.MovingTheKey2 = true;
//				holding = true;
//				PressPad.active = false;
//				ReleasePad.active = true;
//
//			}
//			///Release the key with R key
//			if (Input.GetKeyDown (KeyCode.R) && p==1 && holding==true) 
//			{
//
//				MoveKey.MovingTheKey = false;
//				holding = false;
//				PressPad.active = false;
//				ReleasePad.active = false;
//			}
//			if (Input.GetKeyDown (KeyCode.R) && p==2 && holding==true) 
//			{
//
//				MoveKey.MovingTheKey2 = false;
//				holding = false;
//				PressPad.active = false;
//				ReleasePad.active = false;
//			}
//
//	
//	}
}

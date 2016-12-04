using UnityEngine;
using System.Collections;

public class Key6 : MonoBehaviour {

	public GameObject PressPad;
	public GameObject ReleasePad;
	public int p;
	public bool holding = false;
	public string keyName;

	public void Update()  
	{
		///Release the key with P key
		if (Input.GetKeyDown (KeyCode.P) && p==1 && holding==false) 
		{

			MoveKey6.MovingTheKey = true;
			holding = true;
			PressPad.active = false;
			ReleasePad.active = true;

		}
		if (Input.GetKeyDown (KeyCode.P) && p==2 && holding==false) 
		{

			MoveKey6.MovingTheKey2 = true;
			holding = true;
			PressPad.active = false;
			ReleasePad.active = true;

		}
		///Release the key with R key
		if (Input.GetKeyDown (KeyCode.R) && p==1 && holding==true) 
		{

			MoveKey6.MovingTheKey = false;
			holding = false;
			PressPad.active = false;
			ReleasePad.active = false;
		}
		if (Input.GetKeyDown (KeyCode.R) && p==2 && holding==true) 
		{

			MoveKey6.MovingTheKey2 = false;
			holding = false;
			PressPad.active = false;
			ReleasePad.active = false;
		}

	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		keyName = this.gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		ReleasePad.active = false;

		if (player != null && holding==false)
		{
			if (keyName == "Triangle3")
			{
				PressPad.active = true;
				p = 1;

			}

		}

		if (player2 != null && holding==false)
		{
			if (keyName == "Triangle3")
			{
				PressPad.active = true;
				p = 2;

			}
		}

	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		PressPad.active = false;
		ReleasePad.active = false;

	}
}

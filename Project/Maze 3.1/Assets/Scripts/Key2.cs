using UnityEngine;
using System.Collections;

public class Key2 : MonoBehaviour
{
	public GameObject PressPad;
	public GameObject ReleasePad;
	public int p;
	public bool holding = false;

	public void Update()  
	{
		///Release the key with P key
		if (Input.GetKeyDown (KeyCode.P) && p==1 && holding==false) 
		{
            this.gameObject.GetComponent<Rotateplayer>().enabled = true;
            this.gameObject.GetComponent<Rotateplayer>().pressUp = KeyCode.UpArrow;
            this.gameObject.GetComponent<Rotateplayer>().pressDown = KeyCode.DownArrow;
            this.gameObject.GetComponent<Rotateplayer>().pressLeft = KeyCode.LeftArrow;
            this.gameObject.GetComponent<Rotateplayer>().pressRight = KeyCode.RightArrow;
            MoveKey2.MovingTheKey = true;
			holding = true;
			PressPad.active = false;
			ReleasePad.active = true;

		}
		if (Input.GetKeyDown (KeyCode.P) && p==2 && holding==false) 
		{
            this.gameObject.GetComponent<Rotateplayer>().enabled = true;
            this.gameObject.GetComponent<Rotateplayer>().pressUp = KeyCode.W;
            this.gameObject.GetComponent<Rotateplayer>().pressDown = KeyCode.S;
            this.gameObject.GetComponent<Rotateplayer>().pressLeft = KeyCode.A;
            this.gameObject.GetComponent<Rotateplayer>().pressRight = KeyCode.D;
            MoveKey2.MovingTheKey2 = true;
			holding = true;
			PressPad.active = false;
			ReleasePad.active = true;

		}
		///Release the key with R key
		if (Input.GetKeyDown (KeyCode.R) && p==1 && holding==true) 
		{
            this.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey2.MovingTheKey = false;
			holding = false;
			PressPad.active = false;
			ReleasePad.active = false;
		}
		if (Input.GetKeyDown (KeyCode.R) && p==2 && holding==true) 
		{
            this.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey2.MovingTheKey2 = false;
			holding = false;
			PressPad.active = false;
			ReleasePad.active = false;
		}

	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string keyName = this.gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		ReleasePad.active = false;
		if (player != null && holding==false)
		{
			if (keyName == "Cloud")
			{
				PressPad.active = true;
				p = 1;

			}

		}

		if (player2 != null && holding==false)
		{
			if (keyName == "Cloud")
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
//    void OnTriggerEnter2D(Collider2D otherCollider)
//    {
//        Debug.Log("TEST Collider");
//        string keyName = this.gameObject.name;
//        PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
//        PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
//
//        if (player != null)
//        {
//            if (keyName == "Cloud")
//            {
//                MoveKey2.MovingTheKey = true;
//            }
//
//
//        }
//
//        if (player2 != null)
//        {
//            if (keyName == "Cloud")
//            {
//                MoveKey2.MovingTheKey2 = true;
//            }
//
//        }
//    }

}
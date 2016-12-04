using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{

	public static bool displayMessage=false;
	public GUIStyle guiStyle=new GUIStyle();
	public int p;

	public void Update()  
	{
		if (Input.GetKeyDown (KeyCode.P) && p==1) 
		{
			//addingTheKey (1001);
			MoveBox.MovingTheKey = true;
			//MoveKey.MovingTheKey2 = true;
			displayMessage = false;
		}
		if (Input.GetKeyDown (KeyCode.P) && p==2) 
		{
			//addingTheKey (1001);
			//MoveKey.MovingTheKey = true;
			MoveBox.MovingTheKey2 = true;
			displayMessage = false;
		}

		if (Input.GetKeyUp (KeyCode.P)) 
		{
			displayMessage = false;
		}
		if (Input.GetKeyUp (KeyCode.R)) 
		{
			MoveBox.MovingTheKey2 = false;
			MoveBox.MovingTheKey = false;
		}
	}

	public void OnGUI()
	{
		if (displayMessage) {
			guiStyle.fontSize =20;
			guiStyle.normal.textColor = Color.white;
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 200f, 200f), ("Press 'P' to grab the Box"), guiStyle);
		}
	} 

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		//string keyName = this.gameObject.name;
		PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();

		if (player != null)
		{
			//  if (keyName == "Triangle")
			//  {
			displayMessage = true;
			p = 1;
			MoveBox.MovingTheKey = true;
			//  }


		}

		if (player2 != null)
		{
			//if (keyName == "Triangle")
			// {
			displayMessage = true;
			p = 2;
			MoveBox.MovingTheKey2 = true;
			//   }

		}
	}
}
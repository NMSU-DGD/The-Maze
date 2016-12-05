using UnityEngine;
using System.Collections;

public class MoveKey4 : MonoBehaviour
{

	Vector3 avaPos;
	Vector3 avaPos2;
	GameObject theAvatar;
	GameObject theAvatar2;
	public static bool MovingTheKey = false;
	public static bool MovingTheKey2 = false;

	// Use this for initialization

	// Update is called once per frame
	void Update()
	{

		theAvatar = GameObject.FindGameObjectWithTag("player1");
		theAvatar2 = GameObject.FindGameObjectWithTag("player2");

		if (theAvatar != null)
		{
			avaPos = theAvatar.transform.position;
			avaPos2 = theAvatar2.transform.position;
		}

		if (MovingTheKey && UsingKey4.useTheKey)
		{
			this.gameObject.transform.position = new Vector3(avaPos.x, avaPos.y, avaPos.z);
		}
		if (MovingTheKey2 && UsingKey4.useTheKey)
		{
			this.gameObject.transform.position = new Vector3(avaPos2.x, avaPos2.y, avaPos2.z);
		}
	}
}

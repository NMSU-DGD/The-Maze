﻿using UnityEngine;
using System.Collections;

public class MoveKey5 : MonoBehaviour
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

		if (MovingTheKey && UsingKey5.useTheKey)
		{
			this.gameObject.transform.position = new Vector3(avaPos.x * 0.97f, avaPos.y, avaPos.z);
		}
		if (MovingTheKey2 && UsingKey5.useTheKey)
		{
			this.gameObject.transform.position = new Vector3(avaPos2.x * 0.97f, avaPos2.y, avaPos2.z);
		}
	}
}

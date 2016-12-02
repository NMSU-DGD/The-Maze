﻿using UnityEngine;
using System.Collections;

public class Rotateplayer : MonoBehaviour {

	public KeyCode pressUp;
	public KeyCode pressDown;
	public KeyCode pressLeft;
	public KeyCode pressRight;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (pressUp))
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, 0);

		if (Input.GetKeyDown (pressDown))
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, 180);

		if (Input.GetKeyDown (pressLeft))
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, 90);

		if (Input.GetKeyDown (pressRight))
			GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, -90);
	}
}

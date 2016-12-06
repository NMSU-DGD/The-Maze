using System.Collections;
using UnityEngine;
//using UnityEngine.Networking;

public class SimpleMove2D2 : MonoBehaviour
{
	public float Distance = 0;

	private Movement2D mvnt1 = null;

	private void Start()
	{
		mvnt1 = GetComponent<Movement2D>();
	}

	private void Update()
	{
		mvnt1.MoveAlongX(Input.GetAxis("Horizontal01") * Distance * Time.deltaTime);
		mvnt1.MoveAlongY(Input.GetAxis("Vertical01") * Distance * Time.deltaTime);
		//		if (Input.GetKeyDown(KeyCode.Space))
		//		{
		//			mvnt.SmoothGridMove(Vector2.right, Distance, false);
		//		}

//		if (Input.GetKeyDown (KeyCode.Space)) {
//			Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
//			Debug.Log("Plan");
//			GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.position += temp;
//			GameObject.Find("Planningmap").GetComponent<Camera>().enabled = true;
//		}

//		if (Input.GetKeyUp (KeyCode.Space)) {
//			Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
//			GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.position -= temp;
//			Debug.Log("Plan");
//			GameObject.Find("Planningmap").GetComponent<Camera>().enabled = false;
//		}
	}
}



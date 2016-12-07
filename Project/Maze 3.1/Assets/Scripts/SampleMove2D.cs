using System.Collections;
using UnityEngine;
//using UnityEngine.Networking;

public class SampleMove2D : MonoBehaviour
{
    public float Distance = 0;

    private Movement2D mvnt = null;

    private void Start()
    {
        mvnt = GetComponent<Movement2D>();
    }

    private void Update()
    {
        mvnt.MoveAlongX(Input.GetAxis("Horizontal") * Distance * Time.deltaTime);
        mvnt.MoveAlongY(Input.GetAxis("Vertical") * Distance * Time.deltaTime);
//		if (Input.GetKeyDown(KeyCode.Space))
//		{
//			mvnt.SmoothGridMove(Vector2.right, Distance, false);
//		}

//		//if (Input.GetKeyDown (KeyCode.Space)) {
//			GameObject.Find("Canvas (1)").GetComponent<Canvas>().enabled = false;
//			Vector3 temp1 = new Vector3(7.4f,20.0f,-2.0f);
//			Debug.Log("Plan");
//			GameObject.Find ("Main Camera 01").GetComponent<Camera> ().transform.position += temp1;
//			GameObject.Find("Planningmap").GetComponent<Camera>().enabled = true;
//		//}


		if (Input.GetKeyDown (KeyCode.Space)) {
		GameObject.Find("Canvas (1)").GetComponent<Canvas>().enabled = false;
		GameObject.Find("StartPlanning").GetComponent<Canvas>().enabled = false;
		Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
		Debug.Log("Plan");
		GameObject.Find ("Main Camera 01").GetComponent<Camera> ().transform.position += temp;
		GameObject.Find("Planningmap").GetComponent<Camera>().enabled = true;
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			GameObject.Find("Canvas (1)").GetComponent<Canvas>().enabled = true;
			Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
			GameObject.Find ("Main Camera 01").GetComponent<Camera> ().transform.position -= temp;
			Debug.Log("Plan");
			GameObject.Find("Planningmap").GetComponent<Camera>().enabled = false;

		}
    }
}
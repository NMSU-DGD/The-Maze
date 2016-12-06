using UnityEngine;
using System.Collections;

public class EnterMinimap : MonoBehaviour {

	public GameObject minimap;

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		GameObject.Find("Level2Canvas").GetComponent<Canvas>().enabled = false;
		string keyName = gameObject.name;
		SampleMove2D player = otherCollider.gameObject.GetComponent<SampleMove2D>();
		if (player != null) {
			if (keyName == "Plan")
			{
				Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
				Vector3 temp2 = new Vector3(3.0f,3.0f,0);
				Debug.Log("Plan");
				//myGameObject.transform.position += temp;
				//GameObject.Find("Planningmap").GetComponent<Camera>().transform.position.y;
				GameObject.Find ("Main Camera 02").GetComponent<Camera> ().transform.position += temp;
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.localScale = temp2;
				GameObject.Find("Planningmap").GetComponent<Camera>().enabled = true;

			}
		}
		SimpleMove2D2 player2 = otherCollider.gameObject.GetComponent<SimpleMove2D2>();
		if (player2 != null) {
			if (keyName == "Plan")
			{
				Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
				Vector3 temp2 = new Vector3(3.0f,3.0f,0);
				Debug.Log("Plan");
				//myGameObject.transform.position += temp;
				//GameObject.Find("Planningmap").GetComponent<Camera>().transform.position.y;
				GameObject.Find ("Main Camera 01").GetComponent<Camera> ().transform.position += temp;
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.localScale = temp2;
				GameObject.Find("Planningmap").GetComponent<Camera>().enabled = true;
			}
		}
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		GameObject.Find("Level2Canvas").GetComponent<Canvas>().enabled = true;
		string keyName = gameObject.name;
		SimpleMove2D2 player2 = otherCollider.gameObject.GetComponent<SimpleMove2D2>();
		if (player2 != null) {
			if (keyName == "Plan")
			{
				//Vector3 temp2 = new Vector3(2.27f,2.28f,0.5f);
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.localScale = temp2;
				Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
				GameObject.Find ("Main Camera 01").GetComponent<Camera> ().transform.position -= temp;
				Debug.Log("Plan");
				//GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
				GameObject.Find("Planningmap").GetComponent<Camera>().enabled = false;
			}
		}

		SampleMove2D player = otherCollider.gameObject.GetComponent<SampleMove2D>();
		if (player != null) {
			if (keyName == "Plan")
			{
				//Vector3 temp2 = new Vector3(2.27f,2.28f,0.5f);
				//GameObject.Find ("Main Camera").GetComponent<Camera> ().transform.localScale = temp2;
				Vector3 temp = new Vector3(7.4f,20.0f,-2.0f);
				GameObject.Find ("Main Camera 02").GetComponent<Camera> ().transform.position -= temp;
				Debug.Log("Plan");
				//GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
				GameObject.Find("Planningmap").GetComponent<Camera>().enabled = false;
			}
		}
	}
}

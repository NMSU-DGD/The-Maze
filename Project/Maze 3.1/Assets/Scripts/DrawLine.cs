using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class DrawLine : MonoBehaviour {

	private LineRenderer line;
	private bool isMousePressed;
	private Color color;
	public List<Vector3> pointsList;
	private Vector3 mousePos;
	private Vector2 _offset;

	// Structure for line points
	struct myLine
	{
		public Vector3 StartPoint;
		public Vector3 EndPoint;
	};
	//    -----------------------------------    
	void Awake ()
	{
		// Create line renderer component and set its property
		line = gameObject.AddComponent<LineRenderer> ();
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.SetVertexCount (0);
		line.SetWidth (0.1f, 0.1f);
		line.SetColors (Color.green, Color.green);

		line.useWorldSpace = true;
		isMousePressed = false;
		pointsList = new List<Vector3> ();
	}

	void Update ()
	{
		
		if (GameObject.Find ("Planningmap").GetComponent<Camera> ().enabled == true) {
			//if (Input.GetKeyDown (KeyCode.Backspace)) {
				Debug.Log ("in ");
				if (Input.GetMouseButtonUp (0)) {
					Debug.Log ("mouseup");
					isMousePressed = false;
					line.SetColors (Color.red, Color.red);
				}

				if (Input.GetMouseButtonDown (0)) {
					isMousePressed = true;
					line.SetVertexCount (0);
					line.SetColors (Color.green, Color.green);
				}

				if (Input.GetMouseButtonDown (1)) {
					line.SetVertexCount (0);
					Debug.Log ("right click");
					pointsList.RemoveRange (0, pointsList.Count);
				}
					
			

				// Drawing line when mouse is moving(presses)
				if (isMousePressed) {
					mousePos = Camera.current.ScreenToWorldPoint (Input.mousePosition);
					mousePos.z = -2;
					pointsList.Add (mousePos);
					line.SetVertexCount (pointsList.Count);
					line.SetPosition (pointsList.Count - 1, (Vector3)pointsList [pointsList.Count - 1]);
				}
			//}
		}
	}
}
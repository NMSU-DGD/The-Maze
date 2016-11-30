using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class PlayerController_Net : NetworkBehaviour {

	// Use this for initialization
	[Header("Movement Variables")]
	[SerializeField] float movementSpeed= 5.0f;
	[SerializeField] float turnSpeed= 45.0f;
	[Header("Camera Positition Variables")]
	[SerializeField] float cameraDistance= 16f;
	[SerializeField] float cameraHeight= 16f;

	Rigidbody2D localRigidBody;
	Transform mainCamera;
	Vector3 cameraOffset;
	void Start () {
		if (!isLocalPlayer) {
			Destroy (this);
			return;
		}

		localRigidBody = GetComponent<Rigidbody2D> ();
		cameraOffset = new Vector3 (0f, cameraHeight, -cameraDistance);
		mainCamera = Camera.main.transform;
		MoveCamera ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		float turnAmount = CrossPlatformInputManager.GetAxis ("Horizontal");
		float moveAmount = CrossPlatformInputManager.GetAxis ("Vertical");
		Vector3 deltaTranslation = transform.position + transform.forward * movementSpeed * moveAmount * Time.deltaTime;
		localRigidBody.MovePosition (deltaTranslation);

		//Quaternion deltaRotation = Quaternion.Euler (turnSpeed * new Vector3 (0, turnAmount, 0) * Time.deltaTime);
		//localRigidBody.MoveRotation (localRigidBody.rrotation * deltaRotation);

		MoveCamera ();

	}

	void MoveCamera()
	{
		mainCamera.position = transform.position;
		//mainCamera.rotation = transform.rotation;
		mainCamera.Translate (cameraOffset);
		mainCamera.LookAt (transform);
	}
}

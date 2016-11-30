using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
	public string ipaddress = Network.player.ipAddress;
	public GameObject KeyObjectPrefab;
	public Transform KeyObjectSpawn;

	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var x = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f;

		transform.Translate(0, x, 0);
		transform.Translate(y, 0, 0);

		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			CmdPickKey();
		}*/
		CmdPickKey();

	}

	[Command]
	void CmdPickKey()
	{

		var KeyObject = (GameObject)Instantiate (
			KeyObjectPrefab,
			KeyObjectSpawn.position,
			KeyObjectSpawn.rotation);

		// Add velocity to the object
		//KeyObject.GetComponent<Rigidbody2D>().velocity = KeyObject.transform.forward * 6;

		NetworkServer.Spawn(KeyObject);

		// Destroy the object after 2 seconds
		//Destroy(KeyObject, 2.0f);
	}


	public override void OnStartLocalPlayer()
	{
		GetComponent<SpriteRenderer>().color=Color.blue;
		Debug.Log (ipaddress);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
	public string ipaddress = Network.player.ipAddress;
	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}
		var y = Input.GetAxis("Horizontal") * Time.deltaTime * 4.0f;
		var x = Input.GetAxis("Vertical") * Time.deltaTime * 4.0f;

		transform.Translate(0, x, 0);
		transform.Translate(y, 0, 0);

	}

	public override void OnStartLocalPlayer()
	{
		GetComponent<SpriteRenderer>().color=Color.blue;
		Debug.Log (ipaddress);
	}
}
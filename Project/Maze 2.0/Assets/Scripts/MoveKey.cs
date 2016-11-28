using UnityEngine;
using System.Collections;

public class MoveKey : MonoBehaviour {

    Vector3 avaPos;
    GameObject theAvatar;
    public static bool MovingTheKey = false;
    // Use this for initialization
	
	// Update is called once per frame
	void Update () {

        theAvatar = GameObject.Find("Player(Clone)");
        if (theAvatar != null)
        {
            avaPos = theAvatar.transform.position;
        }

        if (MovingTheKey)
        {

            this.gameObject.transform.position = new Vector3(avaPos.x, avaPos.y*1.05f, avaPos.z);
            this.gameObject.transform.rotation = theAvatar.transform.rotation;
        }

    }
}

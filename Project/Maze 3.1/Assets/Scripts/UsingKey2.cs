using UnityEngine;
using System.Collections;

public class UsingKey2 : MonoBehaviour
{
    GameObject cloud;
    public static bool useTheKey = true;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        cloud = GameObject.Find("Cloud");
        MoveKey2 key1 = otherCollider.gameObject.GetComponent<MoveKey2>();
        if (key1 != null)
        {
            cloud.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey2.MovingTheKey = false;
            KeyCounterScript.score -= 1;
            GameObject.Find("Door04").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Door04").GetComponent<BoxCollider2D>().enabled = false;
            useTheKey = false;
        }

    }

}

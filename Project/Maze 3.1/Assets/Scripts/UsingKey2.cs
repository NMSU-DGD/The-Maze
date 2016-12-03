using UnityEngine;
using System.Collections;

public class UsingKey2 : MonoBehaviour
{

    public static bool useTheKey = true;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveKey2 key1 = otherCollider.gameObject.GetComponent<MoveKey2>();
        if (key1 != null)
        {
            MoveKey.MovingTheKey = false;
            KeyCounterScript.score -= 1;
            GameObject.Find("Door04").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Door04").GetComponent<BoxCollider2D>().enabled = false;
            useTheKey = false;
        }

    }

}

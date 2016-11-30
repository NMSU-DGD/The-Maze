using UnityEngine;
using System.Collections;

public class UsingKey : MonoBehaviour {

    public static bool useTheKey = true;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveKey key1 = otherCollider.gameObject.GetComponent<MoveKey>();
        if (key1 != null)
        {
            MoveKey.MovingTheKey = false;
            KeyCounterScript.score -= 1;
            GameObject.Find("t").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("t").GetComponent<BoxCollider2D>().enabled = false;
            useTheKey = false;
        }

    }

}

using UnityEngine;
using System.Collections;

public class UsingKey3 : MonoBehaviour
{

    public static bool useTheKey = true;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        MoveKey3 key1 = otherCollider.gameObject.GetComponent<MoveKey3>();
        if (key1 != null)
        {
            MoveKey.MovingTheKey = false;
            KeyCounterScript.score -= 1;
            GameObject.Find("Door07").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Door07").GetComponent<BoxCollider2D>().enabled = false;
            useTheKey = false;
        }

    }

}

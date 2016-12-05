using UnityEngine;
using System.Collections;

public class UsingKey3 : MonoBehaviour
{
    GameObject triangle;
    public static bool useTheKey = true;
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        triangle = GameObject.Find("Triangle");
        MoveKey3 key1 = otherCollider.gameObject.GetComponent<MoveKey3>();
        if (key1 != null)
        {
            triangle.gameObject.GetComponent<Rotateplayer>().enabled = false;
            MoveKey3.MovingTheKey = false;
            KeyCounterScript.score -= 1;
            GameObject.Find("Door07").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Door07").GetComponent<BoxCollider2D>().enabled = false;
            useTheKey = false;
        }

    }

}

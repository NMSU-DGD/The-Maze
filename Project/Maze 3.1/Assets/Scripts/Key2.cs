using UnityEngine;
using System.Collections;

public class Key2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("TEST Collider");
        string keyName = this.gameObject.name;
        PlayerMovement player = otherCollider.gameObject.GetComponent<PlayerMovement>();
        PlayerMovement02 player2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();

        if (player != null)
        {
            if (keyName == "Cloud")
            {
                MoveKey2.MovingTheKey = true;
            }


        }

        if (player2 != null)
        {
            if (keyName == "Cloud")
            {
                MoveKey2.MovingTheKey2 = true;
            }

        }
    }
}
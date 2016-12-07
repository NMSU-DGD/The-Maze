using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CollectingInfo : MonoBehaviour {

    public Inventory addInfo;

    void Start()
    {
        addInfo = GameObject.Find("Inventory").GetComponent<Inventory>();
    }


    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        string infoName = gameObject.name;
		PlayerMovement avatar = otherCollider.gameObject.GetComponent<PlayerMovement>();
		PlayerMovement02 avater2 = otherCollider.gameObject.GetComponent<PlayerMovement02>();
		if (avatar != null || avater2)
        {
            if(infoName == "info1")
            {
                addingTheInfo(0);
            }
            else if(infoName == "info2")
            {
                addingTheInfo(1);
            }
            else if (infoName == "info3")
            {
                addingTheInfo(2);
            }
            else if (infoName == "info4")
            {
                addingTheInfo(3);
            }
            else if (infoName == "info5")
            {
                addingTheInfo(4);
            }
            else if (infoName == "info6")
            {
                addingTheInfo(5);
            }
        }

    }

    void addingTheInfo(int id)
    {
        addInfo.AddItem(id);
        Destroy(gameObject);
    }
}


﻿using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public int worth = 1;
    public CollectingKey addKey;
	bool displayMessage=false;
	public GUIStyle guiStyle=new GUIStyle();

	public void OnGUI()
	{
		if (displayMessage) {
			guiStyle.fontSize =20;
			guiStyle.normal.textColor = Color.white;
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 200f, 200f), ("Press 'P' to grab the key"), guiStyle);
		}
	} 


    void Start()
    {
	displayMessage = false;
        addKey = GameObject.Find("Collecting Key").GetComponent<CollectingKey>();
        
    }
	
	public void Update()  
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			addingTheKey (1001);
			displayMessage = false;
		}
			
	}

    void OnTriggerEnter2D(Collider2D otherCollider)
	{
        string keyName = this.gameObject.name;
        Movement2D player = otherCollider.gameObject.GetComponent<Movement2D>();
        Debug.Log("Test11111");
        Debug.Log(keyName);
        if (player != null)// && CollectingKey.numberofKey<1)
        {
            Debug.Log("Test22222");
			if (keyName == "testKeyN")
            {
                Debug.Log("Test3333");
               displayMessage = true;
				//addingTheKey(1001);
            }

            KeyCounterScript.score += worth;
			//Destroy (gameObject);


		}

	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		displayMessage = false;
	}
	
    void addingTheKey(int id)
    {
        //  addKey.AddKey(id);
        //Destroy(gameObject);
        if (UsingKey.useTheKey)
        {
            MoveKey.MovingTheKey = true;
        }
        

    }
}

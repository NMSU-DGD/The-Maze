using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    GameObject timer;
    float targetTime = 60.00f;
    public static bool timeCon = true;
    public GUIText theTimer;
    public GUIText theTime;

    void Start()
    {
        timer = GameObject.Find("theTimer");
        theTime.text = "Timer: ";
		GameObject.Find("BlackCover01").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("Lock01").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("BlackCover02").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("Lock02").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("BlackCover03").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("Lock03").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("BlackCover04").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("Lock04").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("BlackCover05").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find("Lock05").GetComponent<SpriteRenderer>().enabled = true;
    }

    void Update()
    {
        if (targetTime > 0)
        {
			
            targetTime -= Time.deltaTime;
            theTimer.text = targetTime.ToString("00.0");
            timer.GetComponent<Text>().text = theTime.text +"      "+ theTimer.text;

        }

    }

}
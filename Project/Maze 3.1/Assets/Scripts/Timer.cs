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
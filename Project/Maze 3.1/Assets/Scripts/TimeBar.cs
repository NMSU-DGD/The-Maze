using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour {
	public Transform LoadingBar;
	public Transform Text1;
	public Transform Text2;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	public static bool Flag = false;
	public Activate extra = null;
	public GameObject GameOver;
	// Update is called once per frame
	void Update () {

			if (currentAmount <= 180 && currentAmount >=0) {
				currentAmount -= speed * Time.deltaTime;
				Text1.GetComponent<Text> ().text = ((int)currentAmount).ToString ();
				Text2.gameObject.SetActive (true);

			} else {
			GameOver.active = true;	
			Text2.gameObject.SetActive (false);
			Text1.GetComponent<Text> ().text = "DONE!";
			transform.parent.gameObject.AddComponent<GameOverScript>();
				
				//Destroy(GameObject.Find("RadialProgressBar"));
				//GameObject.FindGameObjectWithTag ("GameOver").GetComponent<Image> ().enabled = true;
			}
			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 180;
		}

	public void extraTime(int bonus){
		Debug.Log("in extraTime");
		currentAmount += 10;

	}

}

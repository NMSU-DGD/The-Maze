using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading : MonoBehaviour {
	public Transform LoadingBar;
	public Transform Text1;
	public Transform Text2;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			Text1.GetComponent<Text>().text = ((int)currentAmount).ToString () + "%";
			Text2.gameObject.SetActive (true);

		} else {
			Text2.gameObject.SetActive (false);
			Text1.GetComponent<Text>().text = "DONE!";
			Destroy(GameObject.Find("RadialProgressBar"));
			GameObject.Find("GameImage").GetComponent<Image>().enabled = true;

		}
		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	
	}
}

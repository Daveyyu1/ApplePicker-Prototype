using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	static public int score = 1000;
	// Use this for initialization
	void Awake(){
		if (PlayerPrefs.HasKey ("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt ("ApplePickerHighScore");
		}
		PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "HighScore score: " + score;

		if (score > PlayerPrefs.GetInt ("ApplePickerHighScore")) {
			PlayerPrefs.SetInt ("ApplePickerHighScore", score);
		}
	}
}

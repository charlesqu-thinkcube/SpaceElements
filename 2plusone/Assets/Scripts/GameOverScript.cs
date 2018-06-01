using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Text scoreText;
	// Use this for initialization
	void Awake () {
		scoreText.text = "Score - " + PlayerPrefs.GetInt("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

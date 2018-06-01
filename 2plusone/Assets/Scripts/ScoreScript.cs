using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public int score = 0;
	public Text scoreText;
	private string scoreOutput = "Score - ";
	public static ScoreScript Instance;

	// Use this for initialization
	void Awake () {
		Instance = this;
		PlayerPrefs.SetInt("score", 0);
		scoreText.text = scoreOutput + score;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = scoreOutput + score;
	}
}

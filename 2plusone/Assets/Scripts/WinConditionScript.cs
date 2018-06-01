using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((GameObject.FindGameObjectsWithTag("WaterEnemy").Length <= 0) && (GameObject.FindGameObjectsWithTag("EarthEnemy").Length <= 0) &&
		(GameObject.FindGameObjectsWithTag("FireEnemy").Length <= 0) && (GameObject.FindGameObjectsWithTag("AirEnemy").Length <= 0))
		{
			playerScript.Instance.GameOverScene("WinScreen");
			//Application.LoadLevel("WinScreen");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public float timeLeft = 60f;
	public Text timerText;
		
    void Update()
    {
     	UpdateTimerUI();
   	}

   	void UpdateTimerUI()
   	{
		timeLeft -= Time.deltaTime;
     	if(timeLeft < 0)
      	{
			SceneManager.LoadScene("GameOver");
      	}
      	timerText.text = ((int)timeLeft).ToString();
   	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTransition : MonoBehaviour 
{
	
	public AudioSource audio;
	static AudioTransition AudioT; 
 	void Awake()
 	{
    	if (AudioT == null) 
    	{
        	audio.Play ();
        	DontDestroyOnLoad (gameObject);
            AudioT = this;
        }
        else
        {
            Destroy(gameObject);
        }
     }
 	void Update () 
 	{
     	if(Application.loadedLevelName == "Game")
     	{
         	Destroy(this.gameObject);
     	}
 	}
}

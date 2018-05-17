using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTransition : MonoBehaviour 
{
	
	public AudioSource audio;
	static bool AudioBegin = false; 
 	void Awake()
 	{
    	if (!AudioBegin) 
    	{
        	audio.Play ();
        	DontDestroyOnLoad (gameObject);
        	AudioBegin = true;
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

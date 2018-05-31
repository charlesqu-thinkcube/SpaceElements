using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Transparency();
	}

	void Transparency()
	{
		//SpriteRenderer.color = gameObject.GetComponent<SpriteRenderer>();
		//SpriteRenderer.color = new Color(1f,1f,1f,.5f); 

		//Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
 		//tmp.a = 0f;
 		//gameObject.GetComponent<SpriteRenderer>().color = tmp;
	}
}

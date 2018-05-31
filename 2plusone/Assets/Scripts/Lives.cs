using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {

    public playerScript e;
	// Use this for initialization
	void Start () {
        e.heart1.gameObject.SetActive(true);
        e.heart2.gameObject.SetActive(true);
        e.heart3.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}

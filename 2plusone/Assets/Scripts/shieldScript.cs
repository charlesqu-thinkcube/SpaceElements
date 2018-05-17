using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour {

    public int health;
	// Use this for initialization
	void Start () {
        health = 10;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            health -= 1;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

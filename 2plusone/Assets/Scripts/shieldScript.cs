using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour {

    public int health;
	// Use this for initialization
	void Start () {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

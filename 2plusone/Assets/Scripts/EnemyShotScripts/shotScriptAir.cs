
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotScriptAir : MonoBehaviour {

	public int speed = 5;
	private Rigidbody2D rigid2D;
	public AudioClip shootSound;
	private AudioSource shootSource;
	// Use this for initialization
	
	void Awake()
	{
		shootSource = this.gameObject.AddComponent<AudioSource>();
		shootSource.loop = false;
		shootSource.playOnAwake = false;
		if(shootSound != null)
			shootSource.clip = shootSound;
			shootSource.Play();
	}
	
	void Start () {
		rigid2D = gameObject.GetComponent<Rigidbody2D>();

		rigid2D.velocity = new Vector3(0, speed, 0); 
	}

	void OnBecameInvisible() 
	{ 	
		Destroy(gameObject);
	}

	//destroys any object that is not player when hit
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("AirEnemy"))
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
			ScoreScript.Instance.score += 1;
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotScript : MonoBehaviour {

	public int speed = -5;
	private Vector3 target;
    private Rigidbody2D rigid2D;
	//public GameObject CollisionParticle;
	//public GameObject FireParticle;

	// Use this for initialization
	void Start()
	{
        //gameObject.GetComponent<Rigidbody2D>();

        //this.target = this.transform.position - new Vector3(0, speed, 0);

        rigid2D = gameObject.GetComponent<Rigidbody2D>();

        rigid2D.velocity = new Vector3(0, speed, 0);

        //heart1.gameObject.SetActive(true);
        //heart2.gameObject.SetActive(true);
        //heart3.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive(false);
    }

    //void Awake()
    //{
		//ParticleSystem ps = temp.GetComponent<ParticleSystem>();
    	//FireParticle.SetActive(true);
    //}

    void OnCollisionEnter2D (Collision2D other)
    {
    	//DoStuff(other.gameObject);
	//	DoStuff();
    //if (other.gameObject.tag == "Player")
    //{
    //Destroy(other.gameObject);
    //Destroy(this.gameObject);
    // health -= 1;
   // }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        playerScript ply = other.gameObject.GetComponent<playerScript>();
        if (ply == null)
        {
            return;
        }
        if (!ply.invincible)
        {
            if (other.gameObject.tag == "Player")
            {
                ply.TakeHit();
                //Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }

    void OnBecameInvisible() 
	{ 	
		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
        /*
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                //gameOver.gameObject.SetActive(true);
                break;
        }
        */
    }

    /*
	void DoStuff(GameObject other)
    {
		if(CollisionParticle != null)
		{
			GameObject temp = Instantiate(CollisionParticle, transform.position, Quaternion.identity);
			ParticleSystem ps = temp.GetComponent<ParticleSystem>();
			ps.Play();
			Destroy(temp, ps.main.duration+1f);
		}
		Destroy((Object)this.gameObject);
    }
    */
}

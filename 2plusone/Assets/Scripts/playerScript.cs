using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {

    public static playerScript Instance;
    public GameObject bullet;
	public GameObject bulletWater;
	public GameObject bulletFire;
	public GameObject bulletAir;
	public GameObject bulletEarth;
	//public GameObject spaceship;
	private Rigidbody2D spaceship;
    public GameObject heart1, heart2, heart3;
    public int health = 3;
    public Animator animDie;
    public bool invincible;
    //var r2d = GetComponent<Rigidbody2D>();
    // Use this for initialization
    void Start () {
        invincible = false;
	}

    private void Awake()
    {
        Instance = this;
    }
    //reference - www.lessmilk.com/tutorial/space-shooter-unity-1
    // Update is called once per frame
    void Update () {
		//spaceship.GetComponent<Rigidbody2D>();

		spaceship = gameObject.GetComponent<Rigidbody2D>();
		//spaceship.velocity = new Vector3(0, 0, 0);

		//Vector3 tempVel = spaceship.velocity;
		//spaceship.velocity = tempVel;

		if (Input.GetKey(KeyCode.D))
		{
			spaceship.velocity = new Vector3(10, 0, 0);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			spaceship.velocity = new Vector3(-10, 0, 0);
		}
		else 
		{
			spaceship.velocity = new Vector3(0, 0, 0);
		}

		/*
		//fires water bullet
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			bullet = bulletWater;

			//Instantiate(bullet, transform.position, Quaternion.identity);
		}
		//fires fire bullet
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			bullet = bulletFire;

			//Instantiate(bullet, transform.position, Quaternion.identity);
		}
		//fires air bullet
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			bullet = bulletAir;

			//Instantiate(bullet, transform.position, Quaternion.identity);
		}
		//fires earth bullet
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			bullet = bulletEarth;

			//Instantiate(bullet, transform.position, Quaternion.identity);
		}
		*/

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bullet, transform.position, Quaternion.identity);
            Spawner.Instance.nextBullet();
		}

		if (transform.position.x <= -5.9f)
		{
     		transform.position = new Vector2(-5.9f, transform.position.y);
 		} 
 		else if (transform.position.x >= 5.9f) 
 		{
    		 transform.position = new Vector2(5.9f, transform.position.y);
 		}

	}

    public void TakeHit()
    {
        if (invincible) return;
        Invulnerable();
        health -= 1;

        switch (health)
        {
            case 2:
                //Invulnerable();
                StartCoroutine(RemoveHeart(heart3.gameObject));
                break;
            case 1:
                //Invulnerable();
                StartCoroutine(RemoveHeart(heart2.gameObject));
                break;
            case 0:
                //Invulnerable();
                StartCoroutine(RemoveHeart(heart1.gameObject));
                //gameOver.gameObject.SetActive(true);
                StartCoroutine(GameOver());
                break;

        }
    }

    public void Invulnerable()
    {
            invincible = true;
            StartCoroutine(ExecuteAfterTime());
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2f);

        // Code to execute after the delay

        invincible = false;
    }

    IEnumerator RemoveHeart(GameObject heart)
    {
        Animator anim = heart.GetComponent<Animator>();
        anim.SetTrigger("Die");
        yield return new WaitForSeconds(1f);
        heart.SetActive(false);
    }
   
    IEnumerator GameOver()
    {
        //gameOver.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		SceneManager.LoadScene("GameOver");
    }
}
